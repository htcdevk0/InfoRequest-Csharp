# install.ps1

Param(
    [string] $RepoUrl = "https://github.com/htcdevk0/InfoRequest-Csharp.git",
    [string] $LocalPath = "$PSScriptRoot\InfoRequest-Csharp",
    [string] $NugetFolder = "C:\NugetLocal"
)

Write-Host "🚀 Installing InfoRequest globally..."

if (Test-Path $LocalPath) {
    Write-Host "📂 Repository already exists — updating..."
    Push-Location $LocalPath
    git pull
    Pop-Location
} else {
    Write-Host "📥 Cloning repository $RepoUrl"
    git clone $RepoUrl $LocalPath
}

Push-Location $LocalPath

Write-Host "🛠 Building InfoRequest..."
dotnet build -c Release
dotnet pack -c Release

if (!(Test-Path $NugetFolder)) {
    New-Item -ItemType Directory -Path $NugetFolder | Out-Null
    Write-Host "📁 Created package folder: $NugetFolder"
}

$package = Get-ChildItem -Path ".\bin\Release\" -Filter "*.nupkg" | Select-Object -First 1
if (-not $package) {
    throw "❌ No .nupkg package found. Please verify that build and pack ran successfully."
}
Copy-Item $package.FullName -Destination (Join-Path $NugetFolder $package.Name) -Force
Write-Host "📦 Copied package $($package.Name) to $NugetFolder"

dotnet nuget add source $NugetFolder --name InfoRequestLocal --force

Pop-Location

Write-Host "`n✅ Installation complete!"
Write-Host "You can now use InfoRequest in any project with:"
Write-Host "  dotnet add package InfoRequest --source $NugetFolder"
