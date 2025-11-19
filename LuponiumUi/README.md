
# LuponiumUi

Some small and simple methods to help with Streamer.bot C# Coding.




## Using LuponiumUi
You will need to download the LuponiumUi.dll into your Streamer.bot dlls folder, located in Streamer.bot install folder. If one doesn't exist, create one.

Create a new C# Action, default looks like so:
```csharp
using System;

public class CPHInline
{
	public bool Execute()
	{
		// your main code goes here
		return true;
	}
}
```

You can then add `using LuponiumUi` below the `using System`. This will allow you to start using any custom methods included.

## CPHExtensionMethods
I've included some useful methods to use that are not default within Streamer.Bot, You can use these with or without the dll.

### Emote List Extensions
Streamer.bot will give an argument on specific triggers which contains emotes, usually under Chat Message but other triggers give it too. If you want to check that a specific Emote is used in a chat message, you have the following options:
```csharp
using System;
using Twitch.Common.Models; // Required to use the emoteList argument
using System.Collections.Generic; // Required to use the emoteList argument
using LuponiumUi; // Custom Dll with Methods

public class CPHInline
{
	public bool Execute()
	{
		// Get the Emotes argument with the following CPH method
		CPH.TryGetArg("emotes", out List<Twitch.Common.Models.Emote> emoteList);

		// Would recommend getting this arg (internal)
		// That way the C# action won't run off your own or your bots chat messages
		CPH.TryGetArg("internal", out bool IsInternal); 

		// All methods used below return a bool (true/false)
		emoteList.AnyNameStartsWith("lupos");
		emoteList.ListContains("NoU");
		emoteList.MatchesStringPartial("pride");
		return true;
	}
}
```

