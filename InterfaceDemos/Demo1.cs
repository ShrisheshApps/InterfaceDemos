namespace InterfaceDemos
{
    public class Demo1
    {
        public static void TestDemo1()
        {
            Console.WriteLine("\nExample1: Interface");
            Console.WriteLine("===================");
            Console.WriteLine("Basic Interface Example\n");
            //Use the NokiaBasicFeature
            //first approach
            Console.WriteLine("\nCASE1:");
            NokiaBasicPhone nokiaBasic = new NokiaBasicPhone();
            nokiaBasic.PlaySnakeGame();
            nokiaBasic.SendTextMessage();
            nokiaBasic.AudioCall();
            nokiaBasic.NonContractFunctions();
            //second approach
            Console.WriteLine("\nCASE2:");
            INokiaBasicFeature inokiaBasic = new NokiaBasicPhone();
            inokiaBasic.PlaySnakeGame();
            inokiaBasic.SendTextMessage();
            inokiaBasic.AudioCall();
        }
    }
}
