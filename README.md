# EmojiDebug
Easily write debug messages with emoji in C#

![NugetRelease](https://img.shields.io/nuget/v/EmojiDebug.ColinKiama)

## Tutorial
There are 4 methods to use:
```csharp
EmojiDebug.Write(DebugEmoji, string) 
EmojiDebug.WriteLine(DebugEmoji, string)

EmojiDebug.Write(DebugEmoji, Exception) 
EmojiDebug.WriteLine(DebugEmoji, Exception)
```
So:
```csharp 
EmojiDebug.WriteLine(DebugEmoji.BlackFlag, "Check this out!")
```
Would show: `🏴 Check this out!`

