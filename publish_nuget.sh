#!/bin/bash 
dotnet pack -c Release /p:PackageVersion=$1
mono /usr/local/bin/nuget.exe push -Source https://nuget.cdn.azure.cn/v3/index.json -ApiKey $2 bin/Release/BTBaseSharpLib.$1.nupkg
