using System;
using Unit4.CollectionsLib;

namespace Les16
{
    public class A
    {
        public int x;
        public A() : this(1) { }
        public A(int k) { this.x = k * 10; }
        public virtual int M() { return x; }
    }
    public class B : A
    {
        public int x;
        public B() : this(2) { }
        public B(int k) : base(k + 1) { this.x = base.x + 1; }
        public override int M() { return x; }
    }
    class Les16 : Lession
    {
        public override void Main()
        {

            A a = new A();
            Console.WriteLine(a.x);
            Console.WriteLine(a.M());
            B b = new B();
            Console.WriteLine(b.x);
            Console.WriteLine(b.M());
            a = new B();
            Console.WriteLine(a.x);
            Console.WriteLine(a.M());
            b = (B)a;
            Console.WriteLine(b.x);
            Console.WriteLine(b.M());
        }
    }
}
