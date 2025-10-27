# install.ps1

Param(
    [string] $RepoUrl = "https://github.com/htcdevk0/InfoRequest-Csharp.git",
    [string] $LocalPath = "$PSScriptRoot\InfoRequest-Csharp",
    [string] $NugetFolder = "C:\NugetLocal"
)

Write-Host "🚀 Instalando InfoRequest globalmente..."

if (Test-Path $LocalPath) {
    Write-Host "📂 Repositório já existe — atualizando..."
    Push-Location $LocalPath
    git pull
    Pop-Location
} else {
    Write-Host "📥 Clonando repositório $RepoUrl"
    git clone $RepoUrl $LocalPath
}

Push-Location $LocalPath

Write-Host "🛠 Compilando InfoRequest..."
dotnet build -c Release
dotnet pack -c Release

if (!(Test-Path $NugetFolder)) {
    New-Item -ItemType Directory -Path $NugetFolder | Out-Null
    Write-Host "📁 Criada pasta de pacotes: $NugetFolder"
}

$package = Get-ChildItem -Path ".\bin\Release\" -Filter "*.nupkg" | Select-Object -First 1
if (-not $package) {
    throw "❌ Nenhum pacote .nupkg encontrado. Verifique se o build e pack rodaram corretamente."
}
Copy-Item $package.FullName -Destination (Join-Path $NugetFolder $package.Name) -Force
Write-Host "📦 Copiado pacote $($package.Name) para $NugetFolder"

dotnet nuget add source $NugetFolder --name InfoRequestLocal --force

Pop-Location

Write-Host "`n✅ Instalação concluída!"
Write-Host "Você pode usar o InfoRequest em qualquer projeto com:"
Write-Host "  dotnet add package InfoRequest --source $NugetFolder"
