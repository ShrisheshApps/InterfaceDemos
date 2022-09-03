namespace InterfaceDemos
{
    public class NokiaBasicPhone : INokiaBasicFeature
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
        public void NonContractFunctions()
        {
            Console.WriteLine("Non contract functions allowed via NokiaBasicPhone object, not via interface ref.");
        }
    }
}
