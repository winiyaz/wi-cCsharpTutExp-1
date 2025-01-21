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

            List<string> mistress = ["Nina", "Mina", "Dina", "Dina", "Dina"];

            Console.WriteLine(mistress.Count);

            foreach (string name in mistress)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Fetish Mistress : " + name);
                Console.ResetColor();
            }
        }

        // Hashset also called set - Duplicates are not allowed
        public static void Has1()
        {
            Utils.Label2("HashSet Study");
            HashSet<string> buty =
            [
                "Nin",
                "Mia",
                "Din", // Duplicaiton wont be printed
                "Din", // Duplication wont be printed
                "Din", // Diplication wont be printed
            ];

            Console.WriteLine("Total in HashSet Datatype: " + buty.Count);
            Console.WriteLine("Total in HashSet Datatype: " + buty.GetType());

            foreach (string name in buty)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Fetish Mistress HashSet: " + name);
                Console.ResetColor();
            }
        }

        // Dictionary Data Types
        public static void Dict1()
        {
            Utils.Label2("Dictionary Study");
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Nina", "Panty"},
                {"Mina", "Mina"},
                {"Dina", "Dina"}
            };

            Console.WriteLine("Total in Dictionary Datatype: " + dict.Count);
            Console.WriteLine("Total in Dictionary Datatype: " + dict.GetType());

            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Fetish Mistress Dictionary: " + kvp.Key + " " + kvp.Value);
                Console.ResetColor();
            }

            // Check existence of a kvp 
            if (dict.TryGetValue("Nina", out string? value))
            {
                Console.WriteLine("Nina is a Fetish Mistress");
                Console.WriteLine($"Nina + {value}");
            }
            else
            {
                Console.WriteLine("Nina is not a Fetish Mistress");
            }
        }

        // New methods at this level 
    }

    // New Classes at this level
}