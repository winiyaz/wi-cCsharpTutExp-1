// Main entry point program

using csty2.src;

namespace csty2
{
    class Program
    {

        static void Main(string[] args)
        {
            Utils.Label1("Classes Study");

            Person p1 = new Person("Nina", 20);
            p1.Greet();

        }
    }
}