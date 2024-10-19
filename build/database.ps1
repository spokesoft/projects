


$project = "../src/projects.database"
$dacpac = "../src/projects.database/bin/Release/Projects.Database.dacpac"
$dataProject = "../src/projects.data"
$connectionString = "Data Source=localhost;Initial Catalog=Projects;TrustServerCertificate=true;Integrated Security=SSPI;"

dotnet build $project -c Release
sqlpackage /Action:Publish /SourceFile:$dacpac /TargetConnectionString:$connectionString
dotnet ef dbcontext scaffold $connectionString Microsoft.EntityFrameworkCore.SqlServer -p $dataProject -d --context-dir Contexts -f -o Models --no-onconfiguring --configuration Release


