using System;

public class CPHInline
{
	/// <summary>
    /// COMMAND COOLDOWN RESPONSES
    /// Create a new Execute Code Action and paste this entire code in it, and then Save & Compile
    /// Set this to run on the "Command Cooldown" trigger (Core -> Commands -> Command Cooldown) Criteria = Any
    /// </summary>

    public bool Execute()
	{
		CPH.TryGetArg("globalCooldownLeft", out int globalCooldownLeft);
		CPH.TryGetArg("userCooldownLeft", out int userCooldownLeft);
		CPH.TryGetArg("msgId", out string replyId);
		CPH.TryGetArg("commandName", out string commandName);
		
        // Ignore any command name where it starts with '!!'
        // Use for Commands where you don't want a Cooldown Response.
		if (commandName.StartsWith("!!")) return false;
		
        // Format the Cooldowns into a readable string, instead of 90 seconds it formats to 1:30s
		string gCooldownLength = (globalCooldownLeft / 60).ToString() + ":" + (globalCooldownLeft % 60).ToString("00");
		string uCooldownLength = (userCooldownLeft / 60).ToString() + ":" + (userCooldownLeft % 60).ToString("00");
		
        // No Cooldown on the command, idk, just a random check.
		if (userCooldownLeft <= 0 && globalCooldownLeft <= 0) {
			return false;
		}

        // User & Global Command Cooldown Response
		if (userCooldownLeft > 0 && globalCooldownLeft > 0) {
			CPH.TwitchReplyToMessage($"That command currently has a cooldown. 👤 {uCooldownLength}s - 🌍 {gCooldownLength}s.", replyId, true, true);
			return true;
		}

        // User only Command Cooldown Response
		else if (globalCooldownLeft <= 0 && userCooldownLeft > 0){
			CPH.TwitchReplyToMessage($"That command currently has a cooldown. 👤 {uCooldownLength}s", replyId, true, true);
			return true;
		}

        // Global only Command Cooldown Response
		else if (userCooldownLeft <= 0 && globalCooldownLeft > 0) {
			CPH.TwitchReplyToMessage($"That command currently has a cooldown. 🌍 {gCooldownLength}s.", replyId, true, true);
			return true;

		}
		return true;
	}
}