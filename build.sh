dotnet restore src/Dijkstra/Dijkstra.fsproj
dotnet build src/Dijkstra/Dijkstra.fsproj

dotnet restore src/DijkstraConsole/DijkstraConsole.fsproj
dotnet build src/DijkstraConsole/DijkstraConsole.fsproj

dotnet restore test/DijkstraTest/DijkstraTest.fsproj
dotnet build test/DijkstraTest/DijkstraTest.fsproj