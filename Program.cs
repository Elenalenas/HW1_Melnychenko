using System;

namespace HW1_Melnychenko
{
    class Program
    {
        static void Main(string[] args)
        {
            One one = new One();
            Console.WriteLine("Name: " + one.Name);
            Console.WriteLine("Surname: " + one.Surname);
            Console.WriteLine("Age: " + one.Age);
            Console.Write("Profession: ");
            string profession = Console.ReadLine();
            Console.WriteLine("Nice Guy +11");
            Console.ReadLine();
        }
    }
}
