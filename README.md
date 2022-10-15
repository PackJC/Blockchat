# **Blockchat**


Roles: Admin, Moderator, Premium, Basic, Banned
Upper Bounds: 12 Users to a room
Name: Blockchat, BattleChat

Promoted Premium Rooms on Index Page as Banner

Identity Authentication & Authorization Roles
2FA - email & phone


WebRTC/SignalR
Use STUN/TURN Server to develop video connection that doesn't reveal end-to-end user

https://developer.liveswitch.io/liveswitch-server/guides/what-are-stun-turn-and-ice.html

**How to Setup**

Using `Package Manager Console` run these commands:
```
Add-Migration "Migration1"
Update-Database
Using SendGrid Package for email confirmation and password recovery
SignalR for text chat

```
This create a migration and updates your database.


Now create `appsettings.json` and paste the code below.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=DatabaseName;Trusted_Connection=True;MultipleActiveResultSets=true",
    "BlockchatContextConnection": "Server=(localdb)\\mssqllocaldb;Database=Blockchat;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
Replace DatabaseName and other data with your data.

Now setup SendGrid by using user-secrets to setup API Key.
```
dotnet user-secrets init
dotnet user-secrets set SendGridApiKey [PASTE IN YOUR SENDGRID API KEY]
```
The user secrets configuration will override the appsettings.json configuration.

If you deploy this console application somewhere else, the configuration can be changed using environment variables, command-line arguments, and JSON files.
