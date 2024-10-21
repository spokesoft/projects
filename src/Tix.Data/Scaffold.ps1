
$ConnectionString = "Data Source=localhost;Initial Catalog=Projects;TrustServerCertificate=true;Integrated Security=SSPI;";
dotnet ef dbcontext scaffold $ConnectionString Microsoft.EntityFrameworkCore.SqlServer -d --context-dir Contexts -f -o Models --no-onconfiguring