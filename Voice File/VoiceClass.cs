using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_Survival_RPG.Voice_File
{
    public class Voices
    {
        AudioFileReader? audioFile;
        WaveOutEvent? outputDevice;
        public void Voice(string VoiceName)
        { 
            string soundPath_LootingVoice = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Voice File",VoiceName);
            audioFile = new AudioFileReader(soundPath_LootingVoice);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }
    }
}
