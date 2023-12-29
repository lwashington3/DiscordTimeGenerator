powershell expand-archive DiscordTime\publish\DiscordTime.exe.zip DiscordTime\publish\DiscordTimeFolder
move DiscordTime\publish\DiscordTimeFolder\DiscordTime.exe DiscordTime\publish\DiscordTime.exe
rmdir DiscordTime\publish\DiscordTimeFolder
del DiscordTime\publish\DiscordTime.exe.zip