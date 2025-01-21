//Testing Arrays

namespace csty2.src
{
    public class Dataty
    {
        // Array Data Type
        public static void Array1()
        {
            Utils.Label2("Array Study");

            //Defining a new string array
            string[] names = new string[3];
            names[0] = "Nina";
            names[1] = "Mina";
            names[2] = "Dina";

            // Grabbing a value from the array
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names.Length);
        }

        //Collections or list 
        public static void Collection1()
        {
            Utils.Label2("Collection Study");

            List<string> mistress = new List<string>();
            names.Add("Nina");
            names.Add("Mina");
            names.Add("Dina");

            Console.WriteLine(mistress.[0]);
            Console.WriteLine(mistress.[1]);
            Console.WriteLine(mistress.[2]);
            Console.WriteLine(mistress.Count);

        }
    }
}