# MVC Demo

## How to use Secret Manager tool in .NET Core

```bash
dotnet user-secrets init
dotnet user-secrets set "Authentication:Google:ClientId" "GOOGLE_CLIENT_ID_GOES_HERE"
dotnet user-secrets set "Authentication:Google:ClientSecret" "GOOGLE_CLIENT_SECRET_GOES_HERE"

dotnet user-secrets set "Authentication:Cognito:ClientId" "COGNITO_CLIENT_ID_GOES_HERE"
```

## How to support OpenID Connect in ASP.NET Core

```bash
dotnet add package Microsoft.AspNetCore.Authentication.OpenIdConnect
```

## How to support Google authentication in ASP.NET Core

```bash
dotnet add package Microsoft.AspNetCore.Authentication.Google
```

