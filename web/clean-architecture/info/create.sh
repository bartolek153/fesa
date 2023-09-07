#!/bin/bash


mkdir -p expensave/src
cd expensave

git init
dotnet new gitignore

dotnet new webapi --output src/PublicApi
dotnet new classlib -o src/Core
dotnet new classlib -o src/Application
dotnet new classlib -o src/Infrastructure

dotnet new sln -o src -n expensave
dotnet sln add src/PublicApi
dotnet sln add src/Core
dotnet sln add src/Application
dotnet sln add src/Infrastructure
# dotnet sln add $(ls -R **/*.csproj) does not work

# Dependencies / References

dotnet add PublicApi/ reference Application/
dotnet add PublicApi/ reference Infrastructure/
dotnet add Infrastructure/ reference Application/
dotnet add Application/ reference Core/


# Packages:

  # General Structure
dotnet add Application/ package oneof
dotnet add Infrastructure/ package \
  Microsoft.Extensions.Configuration \
  Microsoft.Extensions.Options.ConfigurationExtensions
dotnet add PublicApi/ package Microsoft.Extensions.DependencyInjection.Abstractions

  # Security
dotnet add Infrastructure/ package Microsoft.AspNetCore.Authentication.JwtBearer

dotnet user-secrets init --project PublicApi/
dotnet user-secrets set --project PublicApi/ "JwtSettings:Secret" "super-secret-key-from-user-secrets"
