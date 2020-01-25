#!/bin/sh
echo "Executing MSBuild DLL begin command..."
dotnet ./tools/sonar/SonarScanner.MSBuild.dll begin /o:"${ORGANIZATION}" /k:"${PROJECT_KEY}" /d:sonar.cs.vstest.reportsPaths="**/TestResults/*.trx" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.verbose=true /d:sonar.login=${LOGIN}
echo "Running build..."
dotnet build EmegenlerSolution.sln
echo "Running tests..."
dotnet test EmegenlerTests/EmegenlerTests.csproj --logger:trx
echo "Executing MSBuild DLL end command..."
dotnet ./tools/sonar/SonarScanner.MSBuild.dll end /d:sonar.login=${LOGIN}