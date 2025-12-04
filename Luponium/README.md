# **Luponium - Streamer.bot C# Extension**

>[!NOTE]
> - **Built to target [Streamer.bot v1.0.1](https://streamer.bot/)**
> - **Ensure to update Streamer.bot before using this Dll Extension.**
>
> ### Installation
> **Ensure you place the dll in the dlls folder of your streamer.bot install.**
> ```
>Your Streamer.bot Install Folder\dlls
>```

## Luponium Features
<details>
<summary>Config Forms</summary>

>[!NOTE]
> **This requires atleast some knowledge of C#.**

This dll extension allows people who make public Streamer.bot resources to create Config Forms within the Streamer.bot UI.<br>
The concept came from having a lot of "Set Argument" actions within some public Streamer.bot Extensions I've seen.

Creating a Config Form using the Dll allows you to use the following:

- Add Text
- Add Blank Line
- Add Number Boxes (Doubles/Integers)
- Add Checkboxs (Booleans)
- Add Dropdown (Lists)
- Add Hover Tooltips (For a little extra help for the User)
- Add Password Boxes
- Add Text Input (Strings)

You can add as many of these into the form as you like.
    <details>
	    <summary><b>Streamer.bot Execute Code Example</b></summary>

```cs
using System;
using LuponiumUi;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Linq;

public class CPHInline
{
    // Dictionary required to save user input to, can be used across this Execute C# Code action.
	public Dictionary<string,object> configSettings = new();

	public bool Execute()
    {
        // your main code goes here
        return true;
    }

	// Show the Config form
	// Call this method using a "C# Execute Code Method" Action with "Run on UI Thread" Enabled
	public bool ShowConfigForm()
    {
        LuponiumForm configForm = ConfigForm();

        if (configForm.ShowDialog() == DialogResult.OK)
        {
            configSettings = configForm.ResultValues;
			// Save Dictionary to a Global Variable, this saves as a string in Streamer.bot
			// When getting the saved Config Values, get it as a Dictionary<string,object>
            CPH.SetGlobalVar("GlobalVariableName", configSettings, true);
            return true;
        }
        return false;
    }

	// Build the Config Form to get User Input
    public LuponiumForm ConfigForm()
    {
        var configForm = new LuponiumForm(string title, int width, int height, int maxWidth, int maxHeight, string okText = "Save", string cancelText = "Cancel");
        // All methods below have overloads, feel free to use them in your own projects
        configForm.AddDropdown(string label, IEnumerable<string> options, string defaultSelected = null, string hint = "", bool required = false, Func<string, bool> validate = null, string key = null);
        configForm.AddCheckbox(string label, bool defaultValue = false, string hint = "", bool required = false, Func<bool, bool> validate = null, string key = null);
        configForm.AddNumber(string label, decimal value = 0, decimal min = 0, decimal max = 100, string hint = "", bool required = false, Func<decimal, bool> validate = null, string key = null);
        configForm.AddPasswordBox(string label, string hint = "", bool required = false, Func<string, bool> validate = null, string key = null);
        configForm.AddTextbox(string label, string defaultValue = "", string hint = "", bool required = false, Func<string, bool> validate = null, string key = null);
        configForm.AddBlankLine(int height = 10);
        return configForm;
    }
}
```
  </details>

</details>
<details><summary>CPH Extended C# Methods</summary>

```cs
public static class CPHExtension
{
    public static bool ListContainsEmote(this List<Twitch.Common.Models.Emote> list, string value, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
    {
        return list.Any(e => e.Name != null && e.Name.Equals(value, comparison));
    }

    public static bool AnyEmoteInList(this List<Twitch.Common.Models.Emote> emotes, List<string> names, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
    {
        return emotes.Any(e => e.Name != null && names.Any(n => n.Equals(e.Name, comparison)));
    }

    public static bool ContainsEmoteKeyword(this List<Twitch.Common.Models.Emote> emotes, IEnumerable<string> keywords)
    {
        return emotes.Any(e => e.Name != null && keywords.Any(k => e.Name.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0));
    }

    public static bool AnyEmoteInListPartial(this List<Twitch.Common.Models.Emote> emotes, IEnumerable<string> names)
    {
        return emotes.Any(e => e.Name != null && names.Any(n => e.Name.IndexOf(n, StringComparison.OrdinalIgnoreCase) >= 0));
    }

    public static bool MatchesStringPartial(this List<Twitch.Common.Models.Emote> emotes, string search)
    {
        if (string.IsNullOrEmpty(search))
            return false;
        return emotes.Any(e => e.Name != null && e.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
    }

    public static bool AnyEmoteStartsWith(this List<Twitch.Common.Models.Emote> emotes, string prefix, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
    {
        if (string.IsNullOrEmpty(prefix))
            return false;
        return emotes.Any(e => e.Name != null && e.Name.StartsWith(prefix, comparison));
    }

    public static bool ListContainsAnyString(this List<string> list, string value, StringComparison comparison)
    {
        return list.Any(s => s != null && s.Equals(value, comparison));
    }

    public static bool IsInternationalName(string UserName)
    {
        return UserName.Any(ch => ch > 127);
    }

    public static bool ListDictionaryContains(this List<Dictionary<string, object>> Dictionary, string Input)
    {
        return Dictionary.Any(dict => dict.ContainsValue(Input));
    }

    public static string ToNumString<T>(this T Number, string NumberFormat = "N00") where T : IFormattable
    {
        return Number.ToString(NumberFormat, CultureInfo.InvariantCulture);
    }
}
```


</details>