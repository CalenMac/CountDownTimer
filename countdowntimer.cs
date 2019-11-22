using System;

namespace countdowntimer
{
    class timer 
    {
        static void Main()
        {
            for (int a = 3; a >= 0; a--)
            {
                Console.Write("Your PC is getting hacked in: {0}", a);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            
            for (int a = 0; a >= 0; a--)
            {
                Console.Write("Hacking status at 10 percent");
                 System.Threading.Thread.Sleep(1000);
                 Console.Clear();
                Console.Write("Hacking status at 35 percent");
                 System.Threading.Thread.Sleep(1000);
                 Console.Clear();
                Console.Write("Hacking status at 95 percent");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                
            }
            
                Console.Write("All you saved passwords on this machine have been uploaded to my private site!");
        }
    }
}
