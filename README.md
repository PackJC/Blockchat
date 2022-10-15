# **Blockchat**


Roles: Admin, Moderator, Premium, Basic, Banned
Upper Bounds: 12 Users to a room
Name: Blockchat, BattleChat

Promoted Premium Rooms on Index Page as Banner

Identity Authentication & Authorization Roles
2FA - email & phone


WebRTC/SignalR
Xsockets.net-4.0
Use STUN/TURN Server to develop video connection that doesn't reveal end-to-end user
https://developer.liveswitch.io/liveswitch-server/guides/what-are-stun-turn-and-ice.html

How to setup projects

Using `Package Manager Console` run these commands:
```
Add-Migration "Migration1"
Update-Database
```
This creates a migration and updates your database.

Using SendGrid Package for email confirmation and password recovery
SignalR for text chat

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
