# Getting packages versions

$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo("$PSScriptRoot/AcspNet.LanguageBar/bin/Release/AcspNet.LanguageBar.dll").FileVersion

# Packing source packages

src\.nuget\NuGet.exe pack AcspNet.LanguageBar/AcspNet.LanguageBar.Sources.nuspec -Version $version

# Publishing to Appveyor artifacts

Get-ChildItem .\*.nupkg | % { Push-AppveyorArtifact $_.FullName -FileName $_.Name }
