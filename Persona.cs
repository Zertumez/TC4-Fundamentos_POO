using System;

namespace TC4_Fundamentos_POO
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public string NombreCompleto
        {
            get => this.nombre + " " + this.apellido;
        }

        private string colorFavorito;

        public string ColorFavorito
        {
            get => this.colorFavorito;
            set => this.colorFavorito = value;
        }
        
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        // void => no devuelve nada
        // virtual => Se puede overridear
        public virtual void Presentarse()
        {
            Console.WriteLine($"¡Hola!, mi nombre es {this.nombre} {this.apellido}.");
        }
    }
}