using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Text_To_Speech1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer spk = new SpeechSynthesizer();
            string message = Console.ReadLine();
            spk.Speak(message);
            Console.WriteLine("OUTPUT!!!");
        }
    }
}
