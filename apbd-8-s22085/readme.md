# Zainstalowane biblioteki:

* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools

# Config
W appsettings.json:

```
 "ConnectionStrings": {
    "DefaultConnection": "Data Source=db-mssql16.pjwstk.edu.pl;Initial Catalog=s22085;Integrated Security=True;TrustServerCertificate=True"
  }
```

## Pamiętać o konfigu bazy danych w `Program.cs`:

```
   builder.Services.AddDbContext<DatabaseContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

# Migracje

Odpalać z konsoli w katalogu sln:

`dotnet ef migrations add AddedTableXYZ`

potem:

`dotnet ef migrations remove` - żeby usunąć migrację

`dotnet ef database update` - żeby wypchnąć migrację na serwer bazy danych

`dotnet ef migrations script` - wygenerowanie na konsole SQL, który zostanie wykonany z migracji na DB



