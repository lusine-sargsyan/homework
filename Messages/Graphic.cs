namespace WelcomeUser
{
    public class Graphic
    {
        public static void WelcomeMessage()
        {
            string text = System.IO.File.ReadAllText(@"Messages\WelcomeMessage.txt");
            System.Console.WriteLine("\n");
            System.Console.WriteLine(text);
            System.Console.WriteLine("\n");
            System.Console.WriteLine("---------------------------------------------------------------------------");
            System.Console.WriteLine("\n");
        }

        public static void EndingMessage()
        {
            string text = System.IO.File.ReadAllText(@"Messages\EndingMessage.txt");
            System.Console.WriteLine("\n");
            System.Console.WriteLine("---------------------------------------------------------------------------");
            System.Console.WriteLine("\n");
            System.Console.WriteLine(text);
        }
    }
}