using System;

namespace countdowntimer
{
    class countdown
    {
        static void Main()
        {
            for (int a = 10; a > 0; a--)
            {
                Console.Write(" Your Computer will blow up in: {0}", a);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
      
        Console.Write ("BOOM!");
    }
  }
}
