using System;
namespace BeginningCSharp
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish() //virtual keyword means this method can be overriden in any subclasses
        {
            Console.WriteLine("The Chef makes BBQ ribs");
        }
    }
}
