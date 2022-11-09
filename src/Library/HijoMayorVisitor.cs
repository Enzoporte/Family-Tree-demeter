using System;
using System.Collections.Generic;

namespace Library
{
    public class HijoMayorVisitor : IVisitor
    {
        public Person Mayor { get; set; }
        public List<Person> MayorPorGeneracion { get; set; }
        public HijoMayorVisitor()
        {
            MayorPorGeneracion = new List<Person>();
        }
        public void Visit(Node node)
        {
            try
            {
                Mayor = node.Children[0].Person;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }

            foreach (var child in node.Children)
            {
                if (child.Person.Edad > Mayor.Edad)
                {
                    Mayor = child.Person;
                }
            }

            MayorPorGeneracion.Add(Mayor);
        }
    }
}