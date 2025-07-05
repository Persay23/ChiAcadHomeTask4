# ChiAcadHomeTask4 - ASP.NET Core Developer Registration App

This is a simple social network for ASP.NET developers built with **ASP.NET Core MVC**, **Razor Pages**, and **PostgreSQL**.  
Users can register with their name and email, then be redirected to a page that declares them an ASP.NET developer and lists all registered developers.

## How to set up

### Clone the repo
```bash
git clone https://github.com/Persay23/ChiAcadHomeTask4.git
cd ChiAcadHomeTask4
```

### Paste your connection string instead of this one 

```
"ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=Hometask4;Username=postgres;Password=MagicTrain23"
}
```

### In the terminal create migration

```bash
dotnet tool install --global dotnet-ef   # Only needed once
dotnet ef database update
```

### Then run the project

```bash
dotnet run
```

### Finally you will see in the console something like this 

```bash
Now listening on: https://localhost:5197
```
This is your address for "site" and "/swagger"
