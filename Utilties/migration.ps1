param([String] $migrationName)

# $currentDirectory = Get-Location

# Set-Location ..\TopTenPresidents.Data\

if ($null -eq $migrationName) {
    Write-Output "migration can't be null.";
}
else {
    dotnet ef migrations add $migrationName -p "..\TopTenPresidentsWebApi\TopTenPresidentsWebApi.csproj" -v
    # dotnet ef migrations add $migrationName -s "..\TopTenPresidentsWebApi\TopTenPresidentsWebApi.csproj" -v
    # dotnet ef migrations add test  -s "..\TopTenPresidentsWebApi\TopTenPresidentsWebApi.csproj" -v
    # dotnet-ef migrations add FileName-to-CodeAlertCodeEventMaster --project "..\CodeAlert.HttpApi.Host\CodeAlert.HttpApi.Host.csproj" -v
    # dotnet ef migrations add $migrationName --project .\TopTenPresidents.Data.csproj
}

# Set-Location $currentDirectory