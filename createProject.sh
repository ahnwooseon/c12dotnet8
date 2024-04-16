#!/bin/bash
dotnet new console -n $1
git add $1/$1.csproj
git add $1/Program.cs
git commit -m "Create project
dotnet new console -n $1"
dotnet sln add $1
git add *.sln
git commit -m "Add project to solution
dotnet sln add $1"
sed -i '$i\\t<ItemGroup>\n\t\t<Using Include="System.Console" Static="true" />\n\t</ItemGroup>' $1/$1.csproj
git add $1/$1.csproj
