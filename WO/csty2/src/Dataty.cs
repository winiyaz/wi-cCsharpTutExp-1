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
        public static void Col1()
        {
            Utils.Label2("Collection Study");

            List<string> mistress = new List<string>();
            mistress.Add("Nina");
            mistress.Add("Mina");
            mistress.Add("Dina");
            mistress.Add("Dina");
            mistress.Add("Dina");

            Console.WriteLine(mistress.Count);

            foreach (string name in mistress)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Fetish Mistress : " + name);
                Console.ResetColor();
            }
        }

        // Hashset - Duplicates are not allowed
        public static void Has1()
        {
            Utils.Label2("HashSet Study");
            HashSet<string> buty = new HashSet<string>();
            buty.Add("Nin");
            buty.Add("Mia");
            buty.Add("Din");
            buty.Add("Din");
            buty.Add("Din");

            Console.WriteLine("Total in HashSet Datatype: " + buty.Count);
            Console.WriteLine("Total in HashSet Datatype: " + buty.GetType());

            foreach (string name in buty)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Fetish Mistress HashSet: " + name);
                Console.ResetColor();
            }
        }
    }
}