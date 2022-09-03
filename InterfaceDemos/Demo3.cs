namespace InterfaceDemos
{
    public class Demo3
    {
        public static void TestDemo3()
        {
            Console.WriteLine("\nExample3: Interface");
            Console.WriteLine("===================");
            Console.WriteLine("Mutiple Interfaces Implementation Example\n");
            Console.WriteLine("A class Implements Mutiple Interfaces");
            //Use the NokiaBasicFeature
            //first approach
            Console.WriteLine("\nCASE1:");
            Console.WriteLine("Accessing All Features");
            GalaxyComboFeaturePhone galaxy = new GalaxyComboFeaturePhone();
            galaxy.PlaySnakeGame();
            galaxy.SendTextMessage();
            galaxy.AudioCall();
            galaxy.SendImages();
            galaxy.VideoCall();
            galaxy.NonContractFunctions();

            Console.WriteLine("\nCASE2:");
            Console.WriteLine("Accessing the Samsung Feature");
            ISamsungFeature samsung = new GalaxyComboFeaturePhone();
            samsung.EncryptData();
            //samsung.PlaySnakeGame(); //not allowed
            //samsung.SendTextMessage(); //not allowed
            //samsung.AudioCall(); //not allowed
            //samsung.SendImages(); //not allowed
            //samsung.VideoCall(); //not allowed

            Console.WriteLine("\nCASE3:");
            Console.WriteLine("Accessing the Nokia Extended Feature");
            INokiaExtendedFeature inokiaX = new GalaxyComboFeaturePhone();
            inokiaX.PlaySnakeGame();
            inokiaX.SendTextMessage();
            inokiaX.AudioCall();
            inokiaX.SendImages();
            inokiaX.VideoCall();
            //inokiaX.NonContractFunctions(); //not allowed

            Console.WriteLine("\nCASE4:");
            Console.WriteLine("Accessing the Nokia Basic Feature");
            INokiaBasicFeature inokiaBasic = new GalaxyComboFeaturePhone();
            inokiaBasic.PlaySnakeGame();
            inokiaBasic.SendTextMessage();
            inokiaBasic.AudioCall();
            //inokiaBasic.SendImages(); //not allowed
            //inokiaBasic.VideoCall(); //not allowed
        }
    }
}
