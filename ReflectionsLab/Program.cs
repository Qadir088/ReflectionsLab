using ReflectionsLab;
using System;

namespace ReflectionsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ali = new Student();
            Console.WriteLine(ali.Age);

            Student murad = new Student();
            Console.WriteLine(murad.Age);

            Student gadir = new Student();
            Console.WriteLine(gadir.Age);

            Student nicat = new Student();
            Console.WriteLine(nicat.Age);
        }
    }
}
