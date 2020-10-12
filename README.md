### Dream Of Electric Sheep
A web service that notifies users of their specified cryptocurrencies when a significant change in value is detected.

To set up local Dotnet Secrets Manager:
```
dotnet user-secrets init
dotnet user-secrets set "Auth0:Identifier" "{Identifier}"
dotnet user-secrets set "Auth0:Domain" "{Domain}"
dotnet user-secrets set "Auth0:ClientIDKey" "{ClientID}"
dotnet user-secrets set "Auth0:Authority" "https://{Domain}"
dotnet user-secrets list
```