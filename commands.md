<a name ="top"></a>
# <b>Luposity's Command Documentation</b>
------

<a name="toc"></a>
## Table of Contents

| **Command Section**                            | **Description**                                     |
| ---------------------------------------------- | --------------------------------------------------- |
| [**Beat Saber Integration**](#beat-saber)      | *Commands for beat saber streams*                   |
| [**Bit Redeems**](#bit-redeems)                | *Bit redeem alerts*                                 |
| [**Chat Currency Commands**](#chat-currceny)   | *For everything about treats (the chat currency)*   |
| [**Emote Reactive Messages**](#EmoteReactives) | *Emotes that trigger custom commands/sounds etc*    |
| [**Fun Commands**](#fun-commands)              | *Just some silly commands that don't fit anywhere.* |
| [**Moderation**](#mod-commands)                | *Commands that are only available for moderators.*  |

------

<a name="Beat Saber Commands"></a>
## [Beat Saber Commands](#top)
>[!Important]
Song Requests for Beat Saber streams is provided using the
[DumbRequestManager](https://github.com/mercurialworld/DumbRequestManager) mod.<br>


| Command                         | Description                                                                                                                                                  |
| ------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| !r<br>!bsr                      | For adding song requests to the queue and for the Beatsaver Link to make requests                                                                            |
| !wip                            | Add a WIP Request (Work in Progress Maps)                                                                                                                    |
| !modAdd [@TargetUser] [BSRCode] | Bypass a request that fails to meet request requirements. Supports adding request for a target if target is before the BSRCode. <br>***(Mods & VIPs Only)*** |
| !toggleq<br>!tq                 | Open or Close the Song Requests Queue <br>***(Mods & VIPs Only)***                                                                                           |
| !link                           | Chat message responds with Current or Last played Beat Saber map info.                                                                                       |
| !queue                          | Responds with the current queue (up to next 5 requests)                                                                                                      |

-----

<a name="EmoteReactives"></a>
## [Emote & Chat Message Reactives](#top)
>[!Note]
> Specific Emotes & Words trigger sounds or chat messages.<br>
> If you don't have access to an emote, the emote reactives will not trigger

### **Channel Specific Emote Reactive**
| Emote                                                                                                     | Effect                         | Twitch Channel                                           |
| --------------------------------------------------------------------------------------------------------- | ------------------------------ | -------------------------------------------------------- |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_3e82b4335784418fbcaa0c60c7f07d6e/default/dark/2.0) | Bot Chat Response              | **[AbsyDaLiof](https://www.twitch.tv/absydaliolf)**      |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_318c14ac340f43539cf844b0828449b3/default/dark/2.0) | Random Sound Clip              | **[ColaKatz](https://www.twitch.tv/colakatz)**           |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_dfea6ae47de44f2c8cfbb1e1120cc97e/default/dark/2.0) | Bot Chat Response & Sound Clip | **[ColaKatz](https://www.twitch.tv/colakatz)**           |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_d5777757c34a4074a0e6317f4eac2c9e/default/dark/2.0) | Bot Chat Response              | **[Luposity](https://www.twitch.tv/luposity)**           |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_1c9dc9a458a5415b893941f6e4220158/default/dark/2.0) | Sound Clip                     | **[Pasketi](https://www.twitch.tv/pasketi)**             |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_e4804570dcfb4b3488321ac7ef8c82e3/default/dark/2.0) | Sound Clip                     | **[Pasketi](https://www.twitch.tv/pasketi)**             |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_85f82c167dd74cbdb5f6ab0d66e28ce5/default/dark/2.0) | Random Sound Clip              | **[PixelGamerPix](https://www.twitch.tv/pixelgamerpix)** |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_905dd0751e574bfbb8970a692861ff41/default/dark/2.0) | Bot Chat Response & Sound Clip | **[PixelGamerPix](https://www.twitch.tv/pixelgamerpix)** |
| ![](https://static-cdn.jtvnw.net/emoticons/v2/emotesv2_9f4448f6c5364b21a0af7b12b3a85eb8/default/dark/2.0) | Random Sound Clip              | **[PixelGamerPix](https://www.twitch.tv/pixelgamerpix)** |

-------
### **None Specific Channel Emote Reactives**
>[!Note]
> The following triggers are linked to words within the emotes, they are not channel specific and can trigger on any emote that meets the word requirement.

| Word                           | Effect                |
| ------------------------------ | --------------------- |
| SixSeven<br>67                 | Chat Message Deleted  |
| Pride                          | Chat Message Response |
| NoU<br>Reverse<br>noyou<br>uno | Chat Message Response |
| Meow                           | Sound Clip            |

-----

### **Chat Message Based Reactives**
>[!Note]
> Using any of these words/phrases in a chat message will trigger a response

| Phrase              | Effect       |
| ------------------- | ------------ |
| @LuphonBot Good bot | Bot Response |
| @LuphonBot Bad bot  | Bot Response |
| Crazy               | Bot Response |