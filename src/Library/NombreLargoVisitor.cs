namespace Library 
{
    public class NombreLargoVisitor : IVisitor
    {
        public Person NombreLargo { get; set; } 
        public void Visit(Node node)
        {
            if (NombreLargo == null) { NombreLargo = node.Person; }
            
            if (node.Person.Nombre.Length > NombreLargo.Nombre.Length)
            {
                NombreLargo = node.Person;
            }
        }
    }
}