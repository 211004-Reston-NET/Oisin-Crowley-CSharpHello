using System.Collections.Generic;
using System;

namespace CollectionFunction
{
    //generic collection 
    public class Collection
    {
        List <string> strings = new List<string>();
    

    public void CollectionMain()
    {
            Console.WriteLine("----CollectionDemo");
            Console.WriteLine("List Demo");

            //adding new elements to collections

            strings.Add("First element");
            strings.Add("second element");
            strings.Add("Third Element");
            



                //for each loop going to iterate through the list and print the list
            Console.WriteLine("==For Each Demo==");
            foreach (string item in strings) 
            {
                Console.WriteLine(item);
            }




            Console.WriteLine();
            Console.WriteLine();
             Console.WriteLine("==For Loop Demo==");
            
            for (int i = 0; i < strings.Count; i+=2)
            {

                ///printing the point in the list that i is at when it is iterating through the list
                Console.WriteLine("The current i variable holds: " + i);
                //printing i the element lists
                Console.WriteLine(strings[i]);
            }
    }
    
    }
}
