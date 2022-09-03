using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemos
{
    public class GalaxyComboFeaturePhone : INokiaExtendedFeature, ISamsungFeature
    {
        public void EncryptData()
        {
            Console.WriteLine("You can encryp the data in Galaxy like Samsung");
        }

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
            Console.WriteLine("Non contract functions allowed via GalaxyComboFeaturePhone object, not via interface ref.");
        }
    }
}
