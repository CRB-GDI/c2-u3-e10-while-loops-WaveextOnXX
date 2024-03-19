namespace exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("1 - New game");
            Console.WriteLine("2 - load game ");
            Console.WriteLine("3 - settings ");
            Console.WriteLine("4 - quit game ");
            Console.WriteLine("***************");

            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                Console.WriteLine("loading new game");
            }

            if (response == 2)
            {
                Console.WriteLine("loading files");
            }

            if (response == 3)
            {
                Console.WriteLine("brightness");
                Console.WriteLine("volume");
                Console.WriteLine("graphics");
            }

            if (response == 4)
            {
                Console.WriteLine("going back to dashboard");
            }
            if (response < 0)
            {
                Console.WriteLine("invalid input");
            }

            if (response > 4)
            {
                Console.WriteLine("invalid input");
            }

            while (response != 4) ;
            {
                Console.WriteLine("**************");
                Console.WriteLine("1 - New game");
                Console.WriteLine("2 - load game ");
                Console.WriteLine("3 - settings ");
                Console.WriteLine("4 - quit game ");
                Console.WriteLine("***************");
            }

           
            if (response == 1)
            {
                Console.WriteLine("loading new game");
            }

            if (response == 2)
            {
                Console.WriteLine("loading files");
            }

            if (response == 3)
            {
                Console.WriteLine("brightness");
                Console.WriteLine("volume");
                Console.WriteLine("graphics");
            }

            if (response == 4)
            {
                Console.WriteLine("going back to dashboard");
            }

            if (response < 0)
            {
                Console.WriteLine("invalid input");
            }

            if (response > 4)
            {
                Console.WriteLine("invalid input");

            }

        }

    }   
}