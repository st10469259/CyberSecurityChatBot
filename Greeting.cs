using CyberSecurityChatbot;
using System;
using System.Media;

namespace CyberSecurityChatBot
{
        public class Greeting
        {
            public Greeting()
            { //start of constructor

                greet();

            }//end of constructor

            private void greet()
            {

                //auto get the path of the voice record
                string path = AppDomain.CurrentDomain.BaseDirectory;

                //rename the path
                string fullpath = path.Replace(@"bin\Debug\", "greeting.wav");

                //load audio, than play the audio after instance
                SoundPlayer voice_play = new SoundPlayer(fullpath);

                //loads the sound
                voice_play.Load();

                //plays it
                voice_play.Play();
            }

        }//end of class
    }//end of file
