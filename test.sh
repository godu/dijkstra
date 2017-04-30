dotnet restore src/Dijkstra/Dijkstra.fsproj
dotnet build src/Dijkstra/Dijkstra.fsproj

dotnet restore src/DijkstraConsole/DijkstraConsole.fsproj
dotnet run --project src/DijkstraConsole/DijkstraConsole.fsproj

dotnet restore test/DijkstraTest/DijkstraTest.fsproj
dotnet test test/DijkstraTest/DijkstraTest.fsproj