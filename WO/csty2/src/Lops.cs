// Loop statements 
namespace csty2.src
{
    public class Loops
    {
        public static void Loop1()
        {
            Utils.Label2("LoopStudy");

            // Simple Loop Operator
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }
            Console.ResetColor();
        }

        // While Loop Function
        public static void Loop2()
        {
            Utils.Label2("While Loop");
            int i = 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            while (i <= 5)
            {
                Console.WriteLine($"Count: {i}");
                i++; // Important counter to prevent an infinite loop
            }
            Console.ResetColor();
        }
    }
}