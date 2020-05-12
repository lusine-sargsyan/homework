using System;

namespace WelcomeUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphic.WelcomeMessage();
            //Մաս 1․ Տպիր "Enter Your name: " և մնա նույն տողում
            //Կոդի սկիզբ
            
                Console.Write("Enter Your Name");
            


            //Կոդի ավարտ
            
            User user = new User (
                //Մաս 2․ Գրիր օգտվողից մուտք պահանջող կոդ
                //Կոդի սկիզբ
                
                    Console.ReadLine()
                

                
                //Կոդի ավարտ
            );

            //Մաս 3․ Տպիր "Enter Your age: " և մնա նույն տողում
            //Կոդի սկիզբ
            
                Console.WriteLine("Enter Your age:");
            


            //Կոդի ավարտ

            user.SetAge (
                Int32.Parse (
                    //Մաս 4․ Գրիր օգտվողից մուտք պահանջող կոդ
                    //Կոդի սկիզբ
                    Console.ReadLine()

                    

                    
                    //Կոդի ավարտ
                )                
            );

            Console.CursorSize = 25;

            Console.WriteLine(user.PrintState());

            Graphic.EndingMessage();
        }
    }
}
