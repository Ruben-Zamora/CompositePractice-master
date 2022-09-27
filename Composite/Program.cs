using Composite.BL;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 

            CompositeElement root =
              new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch

            CompositeElement comp =
              new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement

            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            root.Add(pe);
            //root.Remove(pe);

            //Add test try

           
            CompositeElement test =
            new CompositeElement("Three Triangle");
              test.Add(new PrimitiveElement("Blue Triangle"));
              test.Add(new PrimitiveElement("Red Triangle"));
              CompositeElement pyr =
              new CompositeElement("Pyramid");
                pyr.Add(new PrimitiveElement("Red Triangle Side"));
                pyr.Add(new PrimitiveElement("Black Triangle Side"));
                pyr.Add(new PrimitiveElement("white Triangle Side"));
                pyr.Add(new PrimitiveElement("Base Triangle"));
            root.Add(test);
            test.Add(pyr);
            

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
