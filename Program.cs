using System;
using System.Collections.Generic;


namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty List of type object
            List<object> temp = new List<object>();
            temp.Add(7);
            temp.Add(28);
            temp.Add(-1);
            temp.Add(true);
            temp.Add("chair");

            //Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (Object val  in temp)
            {
                Console.WriteLine(val);
            }

        }
    }
}
