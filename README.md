# eShop
E Commerce Project

> Migration Command

```
dotnet ef migrations add initmigration --context ApplicationDbContext --project .\eShop.Infrastructure\eShop.Infrastructure.csproj --startup-project .\eShop.WebMvc\eShop.WebMvc.csproj
```
```
dotnet ef database update --context ApplicationDbContext --project .\eShop.Infrastructure\eShop.Infrastructure.csproj --startup-project .\eShop.WebMvc\eShop.WebMvc.csproj
```
