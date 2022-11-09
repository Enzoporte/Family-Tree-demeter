using System;
using System.Collections.Generic;
using Library;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Visitors
            HijoMayorVisitor MayorVisitor = new HijoMayorVisitor();
            SumarEdadVisitor SumVisitor = new SumarEdadVisitor();
            NombreLargoVisitor NombreLargoVisitor = new NombreLargoVisitor(); 

            // Nodos
            Node n1 = new Node("Enzo", 70);
            Node n2 = new Node("Enzuli", 50);
            Node n3 = new Node("Enzalada", 48);
            Node n4 = new Node("Enzoporte", 30);
            Node n5 = new Node("Renzo", 29);
            Node n6 = new Node("EnzoCantina", 25);
            Node n7 = new Node("EnzoCantante", 18);
            List<Node> NodeList = new List<Node> {n1, n2, n3, n4, n5, n6, n7};

            // Agregar Hijos
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // Recorrer Nodos Hijos y aplicar los Visitors
            foreach (var node in NodeList)
            {
                node.Accept(SumVisitor);
                node.Accept(MayorVisitor);
                node.Accept(NombreLargoVisitor);
            }

            // Imprimir en pantalla

            Console.WriteLine(SumVisitor.SumaTotal);
            Console.WriteLine(NombreLargoVisitor.NombreLargo.Nombre);
            
            foreach (var item in MayorVisitor.MayorPorGeneracion)
            {
                Console.WriteLine(item.Nombre + ", Edad: " + item.Edad);           
            }
        }
    }
}
