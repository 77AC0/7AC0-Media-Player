## 7AC0 Media Player
A media player I made because I got sick of spotify ads.
### Made in c#

---

### Usage
When you first start the program it will pop-up with the basic start up look. (aka. light theme and no music directory set)

#### Your settings save if you close the program and will apply the settings on launch.

First thing you will want to do is click browse and search for a music directory on your computer that you want to use. (It can search sub-directories and it can play from network locations)

Then, Click a song in the list you want to play and click the play button. If you want to pause click pause, it's self-explanatory.

---

### Q&A

#### Q. How does Shuffle work?<br>
##### A. When you enable it by clicking the check box, When a song ends it will randomally pick the next song and play it.

#### Q. How does Loop work?<br>
##### A. When you enable it by clicking the check box, When a song ends it will pick the next song in your Song List (the current song directory) and play it. No it does not loop the current song you are playing again when it finishes.

#### Q. What is the Discord Motd?<br>
##### A. It is the "Message of the day", If the text box says "Welcome to 7AC0 Media Player" on Discord whilst you have the program open, Click your name in the player list down the right side to see the Rich Presence, When you hover over the image it will show a bubble with the message inside it. You can customise this to anything you want. (I am not liable if you get Kicked or Banned from a server because you set it to something you shouldn't!, Remember EVERYONE CAN SEE THE MESSAGE!)

#### Q. How do you skip a song?<br>
##### A. Whilst Shuffle or Loop are enabled, Click the stop button and it will skip it. If Shuffle and Loop are both disabled, It will fully stop the song.

#### Q. Can I use the media keys on my keyboard to control it?<br>
##### A. Yes and No, Basically the play and pause buttons work and the stop button works (The buttons work the same way as explained earlier), But the program has to be the focus meaning you can't just press the media keys whilst in the middle of game and it will do what you want. To focus it, Just click the window whilst it's not minimizd. I will be fixing this issue but for now that's the solution. (Previous and Next track buttons don't do anything!)

#### Q. I have an issue, How can I let you know about it?<br>
##### A. Post your issue at https://github.com/77AC0/7AC0MediaPlayer/issues and I will try to fix it ASAP!

#### Q. Are you a noob at github?
##### A. Give me a break, Honestly.

---

### Libraries used
<h4>
  <ul style="list-style-type:disc;">
    <li><a href="https://github.com/Fody/Costura">Costura.Fody</a></li>
    <li><a href="https://github.com/Lachee/discord-rpc-csharp">DiscordRichPresence</a></li>
    <li><a href="https://github.com/Fody/Fody">Fody</a></li>
    <li><a href="https://github.com/naudio/NAudio">NAudio</a></li>
    <li><a href="https://www.newtonsoft.com/json">Newtonsoft.Json</a></li>
  </ul>
</h4>
