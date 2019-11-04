using System;
namespace BeginningCSharp
{
    class ItalianChef : Chef //Italian Chef will inherit all the functionality from the chef class
    {
       public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
        public override void MakeSpecialDish() //override keyword means this method will be override in this subclass
        {
            Console.WriteLine("The Chef makes eggplant parmesan");
        }
    }
}
