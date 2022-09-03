namespace InterfaceDemos
{
    public class Demo2
    {
        public static void TestDemo2()
        {
            Console.WriteLine("\nExample2: Interface");
            Console.WriteLine("===================");
            Console.WriteLine("Extend Interface Example\n");
            Console.WriteLine("One Interface extends its power by inheriting another Interface");
            Console.WriteLine("A class Implements the Extended Interface");
            //Use the NokiaBasicFeature
            //first approach
            Console.WriteLine("\nCASE1:");
            NokiaExtendedPhone nokiaExtended = new NokiaExtendedPhone();
            nokiaExtended.PlaySnakeGame();
            nokiaExtended.SendTextMessage();
            nokiaExtended.AudioCall();
            nokiaExtended.SendImages();
            nokiaExtended.VideoCall();
            nokiaExtended.NonContractFunctions();
            //second approach
            Console.WriteLine("\nCASE2:");
            INokiaExtendedFeature inokiaX = new NokiaExtendedPhone();
            inokiaX.PlaySnakeGame();
            inokiaX.SendTextMessage();
            inokiaX.AudioCall();
            inokiaX.SendImages();
            inokiaX.VideoCall();
            //inokiaX.NonContractFunctions(); //not allowed

            //What if we use the INokiaBasicFeature
            Console.WriteLine("\nCASE3:");
            INokiaBasicFeature inokiaBasic = new NokiaExtendedPhone();
            inokiaBasic.PlaySnakeGame();
            inokiaBasic.SendTextMessage();
            inokiaBasic.AudioCall();
            //inokiaBasic.SendImages(); //not allowed
            //inokiaBasic.VideoCall(); //not allowed
        }
    }
}
