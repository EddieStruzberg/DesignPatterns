using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public sealed class Singleton
    {
        private Singleton()
        {
        }

        public static Singleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }

        //Add Methodes----------------
        public void printDetails(string msg)
        {
            Console.WriteLine(msg);
        }
        public void PlayFileInMediaPlayer(string FilePath)
        {
            Console.WriteLine("media player started file " + FilePath);
        }
    }

    public class UseSingleToneExample
    {
        public static void exampleofuse()
        {
            Singleton Teacher = Singleton.Instance;
            Singleton Student = Singleton.Instance;
            Singleton RockMusic = Singleton.Instance;
            Singleton YoutubeLectures = Singleton.Instance;

            Teacher.printDetails("Hi im a Teacher");
            Student.printDetails("Hi im a Student");
            RockMusic.PlayFileInMediaPlayer("RamSthein.mp3");
            YoutubeLectures.PlayFileInMediaPlayer("SingleToneLeacture.mp3");
        }
    }

}
