using System;

namespace over_ridding
{
    class Program
    {
        public void Show()
        {
            Console.WriteLine("This is a parent method");

        }
        public virtual void Test()      //overridable
        {
            Console.WriteLine("This is a also parent");
        }

    }
    class Child: Program
    {
        public void Show(int i)
        {
            Console.WriteLine("Raju was small kid");
        }
        public override void Test()     //overriding
        {
            Console.WriteLine("My name is lucky");
        }
        static void Main()
        {
            Child c = new Child();
            c.Show();
            c.Test();
            c.Show(12);

            Console.ReadLine();
        }
    }

}
