--- pianoTunes ---
![pianoTunes desktop app](https://github.com/horjarobert/PianoTunes/blob/master/pianoTunes.PNG)
***

# 1.Intro # 

+This project is a sample piano keyboard, with 13 notes (like the real first octave from C1 to C2);   

+Each sound was recorded by me from my piano (Yamaha) and then converted from .mp4 to .wav (check this website, is good for converting everything: https://www.online-convert.com/);

+The main scope of this project was to learn new stuff, how to integrate sounds into a Desktop App, and how to design a piano for fun.	
***

# 2.Details #
	
+Please _**turn the volume high**_ to listen an accurate tone... My apologies;

+You must to click with leftClick<<Mouse>> on each button to play a sound (note);

-To integrate sound in C# you need to declare Media namespace, 'using System.Media', also at the beginning I used a voice computer, for that you need this namespace: 

<pre><code>using System.Speech.Synthesis;</code></pre> 

-Next, to make a sound, you need to make an object-instance:

<pre><code>SoundPlayer [object] = new SoundPlayer();</code></pre>

and you need to give it a location ( I put every .wav files into Debug folder ) : 
		
<pre><code>[object].SoundLocation = "file.wav";</code></pre>

So, to use it, for a Click event or whatever you want ... declare it as a method:
<pre><code>[object].Play();</code></pre>

-To use voice computer, follow the same step from sound ... declare an object, initialize an instace:
<pre><code>SpeechSynthesizer [object] = new SpeechSynthesizer();</code></pre>

and start it:

<pre><code>[object].Speak("Your text ... will be spoken out ...!");</code></pre>
***

# 3.Conclusion #

1.I think this project helped me to _**learn**_ new things, maybe to have some fun and for my passion to create and to write code, to learn new things;

2.I found this project really interesting, is _clean_ and _compact_, also easy and enjoyable! 
***

### <em>Enjoy it!</em> ###
***
