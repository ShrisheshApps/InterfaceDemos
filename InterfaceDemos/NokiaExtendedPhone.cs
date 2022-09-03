using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemos
{
    internal class NokiaExtendedPhone : INokiaExtendedFeature
    {
        public void AudioCall()
        {
            Console.WriteLine("You can audio call to someone");
        }

        public void PlaySnakeGame()
        {
            Console.WriteLine("You can play Snake game");
        }

        public void SendTextMessage()
        {
            Console.WriteLine("You can send text message");
        }

        public void SendImages()
        {
            Console.WriteLine("You can send image files");
        }
       
        public void VideoCall()
        {
            Console.WriteLine("You can video call to some one");
        }

        public void NonContractFunctions()
        {
            Console.WriteLine("Non contract functions allowed via NokiaExtendedPhone object, not via interface ref.");
        }

    }
}
