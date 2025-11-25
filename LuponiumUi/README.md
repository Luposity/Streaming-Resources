# **LuponiumUi (V1.0.0)**
> [!IMPORTANT] 
> **This is built for Streamer.bot 1.0.1 and newer. Ensure you update before trying to use this.**

To use this Streamer.bot Dll Extension, ensure it's downloaded into the following folder:
```
Streamer.bot\dlls
```


# **For Extension Development**
> [!NOTE]
> This section is for people who want to utilize the dll for making their own Config Forms with the Luponium dll.

Supports the following:
- Add Text
- Add Blank Line
- Add Number Box
- Add Checkbox Button
- Add Custom Buttons
- Add Dropdown list
- Hover Tooltips

> [!IMPORTANT]  
> If using this for your own projects, ensure a Streamer.bot Execute C# Method function calls a bool to the ShowConfigForm method and is to run on the UI Thread.

## Streamer.Bot "Execute C# Code" Example 
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


