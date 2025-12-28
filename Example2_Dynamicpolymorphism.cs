using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_DynamicPolymorphism
{
    //Dynamin-Polymorphism(Run-time Polymorphism)
    //Base Class
    class Shapes
    {
        //we declare base method virtul to allow over-riding in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Shapes are drawn");
        }
    }
    //Derived classes
    //inheritance in necessary for over riding 
    class Circle : Shapes
    {
     //over ride keyword is used to over ride derived class method
        public override void Draw()
        {
            Console.WriteLine("Circle is drawn");
        }

    }
    class Rectangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle is drawn");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes s1 = new Shapes();
            s1.Draw();
            Shapes s2 = new Circle();
            s2.Draw();
            Shapes s3 = new Rectangle();
            s3.Draw();


        }
    }
}
