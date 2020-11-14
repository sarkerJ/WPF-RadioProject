using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Windows.Media;


namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;
        private bool _isPlaying = false;
        MediaPlayer test = new MediaPlayer();
       // Random rand = new Random();

        public bool Playing { get { return _isPlaying; }  private set { _isPlaying =value; } }

        public int Channel { 
            get { return _channel; } 
            set { if(_on) if(value <=4 && value >=1)_channel = value; } 
        }
       
        //Controls
        public string Play()
        { 
            if (_on)
            {
                string playNow = $"Playing {Channels(_channel)}";
                test.Play();
                Playing = true;
                return playNow;
            }
            else return "Radio is off";
        }
        //off
        public void TurnOff()
        {
            _channel = 1;
            Playing = false;
            _on = false;
            test.Stop();
        }
        //on
        public void TurnOn() {_on = true;}

        //pause
        public void Pause()  { test.Pause(); }

        //Continue
        public void Continue()  {test.Play();}

       // Volume Up
        public double VolUp()
        {
            test.Volume += 0.05;
            return Math.Round(test.Volume * 100, 0);
        }


        //Volume Down
        public double VolDown()
        {
            test.Volume -= 0.05;
            return Math.Round(test.Volume * 100, 0);
        }

        //Channels
        public string Channels(int channel)
        {
            string text = "";
            switch (channel)
            {
                case 1:
                    test.Open(new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p"));
                    text = "Radio 1";
                    break;
                case 2:
                    test.Open(new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p"));
                    text = "Radio 2";
                    break;
                case 3:
                    test.Open(new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio3_mf_p"));
                    text = "Radio 3";
                    break;
                case 4:
                    test.Open(new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio4fm_mf_p"));
                    text = "Radio 4";
                    break;
            }
            return text;
        }

        //PlayList
        string[] audioPath = Directory.GetFiles(@"C:\Users\saadi\OneDrive\Desktop\P files\Songs\", "*.mp3");
        int song = 0;
        public string PlayList()
        {
            if (_on)
            {
                test.MediaEnded += OnMediaEnded;
                test.Open(new Uri(audioPath[song]));
                test.Play();
                return ($"Playing playlist song : {song + 1}");
            }
            else return "Radio is off";
        }
        //automatically plays the next song
        private void OnMediaEnded(object sender, EventArgs e)
        {
            while (song < audioPath.Length - 1) //after it reaches it plays the last song it keeps playing that same song
            {
                song++;
            }
            test.Open(new Uri(audioPath[song]));
            test.Play();
        }

        //Playlist controls
        public string NextSong()
        {
            if (_on)
            {
                song += 1;
                if (song == audioPath.Length) song = 0;
                test.Open(new Uri(audioPath[song]));
                test.Play();
                return ($"Playing playlist song : {song + 1}");
            }
            else return "Radio is off";
        }

        public string PreviousSong()
        {
            if (_on)
            {
                song -= 1;
                if (song < 0) song = audioPath.Length - 1;
                test.Open(new Uri(audioPath[song]));
                test.Play();
                return ($"Playing playlist song : {song + 1}");
            }
            else return "Radio is off";
        }

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}