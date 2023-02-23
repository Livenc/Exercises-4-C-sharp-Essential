using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Player : IPlayable, IRecodable
    {
         void IPlayable.Pause()
        {
            Console.WriteLine("Pause music");
        }
         void IRecodable.Pause()
        {
            Console.WriteLine("Pause record music");
        }


        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

         void IPlayable.Stop()
        {
            Console.WriteLine("Stop play music");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop record music");
        }



    }
}
