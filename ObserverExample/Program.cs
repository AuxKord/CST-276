using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A ();
            B b = new B ();
            C c = new C ();

            a.FruitSalad ( b );
            a.FruitSalad ( c );
        }
    }

    class A
    {
        public void FruitSalad ( I i )
        {
            i.fruit ( this );
        }
        public void apple ()
        {
            Console.WriteLine ( "Apple!" );
        }
    }
    
    interface I
    {
        void fruit ( A a );
    }

    class B : I
    {
        public void fruit ( A a )
        {
            a.apple ();
            Console.WriteLine ( "Banana!" );
        }
    }

    class C : I
    {
        public void fruit ( A a )
        {
            a.apple();
            Console.WriteLine("Cantelope!");
        }
    }
}
