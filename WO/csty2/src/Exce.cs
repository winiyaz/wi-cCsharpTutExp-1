//Exception  handling 


namespace csty2.src
{
    class Exce
    {
        public static void ExceptionMet1()
        {
            Exce1();
            Exce2();
        }

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
            finally
            {
                Console.WriteLine("All Code Fucked Up");
            }
        }

        public static void Exce2()
        {
            Utils.Label2("Exception Study Out of Bonds");

            List<string> shapes = [
                "Square",
                "Rectangle",
                "Circle",
                "Triangle"
            ];

            try
            {
                Console.WriteLine(shapes[30]);
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