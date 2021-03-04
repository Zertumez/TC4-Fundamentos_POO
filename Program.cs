using System;

namespace TC4_Fundamentos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona( "Victor", "Gómez");

            Console.WriteLine(persona1.NombreCompleto);

            persona1.Presentarse();

            // No funciona; no tiene un set
            // persona1.NombreCompleto = "Alberto Rodríguez";

            persona1.apellido = "Rodríguez";
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentarse();

            // persona1.colorFavorito = "morado";
            persona1.ColorFavorito = "morado";

            Console.WriteLine(persona1.ColorFavorito);
        }
    }
}
