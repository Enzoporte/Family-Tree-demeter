using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : IComponenteVisitable
    {
        private List<Node> children = new List<Node>();

        public Person Person;

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string nombre, int edad)
        {
            this.Person = new Person(nombre, edad);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
