using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism.Overriding
{
    class TypeA
    {

        public int A { get; set; }

        public TypeA(int A)
        {
            this.A = A;
        }

        public void MyFun01()
        {
            Console.WriteLine("MyFun01 => I am Base [Parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"MyFun02 : typeA: A = {A}");
        }

    }

    class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int A, int B) : base(A)
        {
            this.B = B;
        }

        // 1. Apply Overriding Using "New" Keyword  => Hiding/Masking Old Method --> New Method .
        public new void MyFun01()
        {
            Console.WriteLine("MyFun01 => I am Child [Derived]");
        }

        // 2. Apply Overriding Using "Virtual" Keyword => Method must be Non-Private and Virtual in Parent Class.
        public override void MyFun02()
        {
            Console.WriteLine($"MyFun02 : typeB: A = {A}, B = {B}");
        }

    }
}
