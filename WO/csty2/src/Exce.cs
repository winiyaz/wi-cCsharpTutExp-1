//Exception  handling 


namespace csty2.src
{
    class Exce
    {
        public static void Exce1()
        {
            Utils.Label2("Exception Study");

            int a = 10;
            int b = 0;

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Utils.Label2("Exception Study Out of Bonds");

            List<string> shapes = new List<string>{
                "Square",
                "Rectangle",
                "Circle",
                "Triangle"
            };

            try
            {
                Console.WriteLine(shapes[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("All Code Fucked Up");
            }
        }
    }
}