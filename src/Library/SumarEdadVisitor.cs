namespace Library
{
    public class SumarEdadVisitor : IVisitor
    {
        public int SumaTotal {get;set;}
        public SumarEdadVisitor()
        {
            this.SumaTotal = 0;
        }
        public void Visit(Node node)
        {
            SumaTotal += node.Person.Edad;
        }
    }
}