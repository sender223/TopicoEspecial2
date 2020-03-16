using System;

namespace TopicoEspecial2 {
    class Program {
        static void Main(string[] args) {

            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            DateTime dt2 = new DateTime(2020, 03, 16, 8, 10, 45);
            Console.WriteLine(dt2.ElapsedTime());

            //importando StringExtensions!
            string s1 = "Bom dia Queridos Estudantes!";
            Console.WriteLine(s1.Cortar(10));

        }
    }
}
