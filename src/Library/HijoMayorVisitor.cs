using System;
using System.Collections.Generic;

namespace Library
{
    public class HijoMayorVisitor : IVisitor
    {
        public Person Mayor { get; set; }

        public void Visit(Node node)
        {
            if (node.Children.Count != 0) return;

            try
            {
                if (node.Person.Edad > Mayor.Edad)
                {
                    Mayor = node.Person;
                }
            }
            catch (System.NullReferenceException)
            {
                Mayor = node.Person;
            }

            

        }
    }
}