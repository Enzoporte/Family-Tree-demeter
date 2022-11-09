namespace Library
{
    public class Person
    {
        public int Edad {get;set;}
        public string Nombre {get;set;}

        public Person (string nombre, int edad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
        }
    }
}