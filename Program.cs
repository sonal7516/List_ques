using System;
using System.Collections.Generic;
using System.Linq;
namespace List_ques
{
    class Program
    {
        
        public void Find_duplicateByLoop()
        {
            List<int> list = new List<int>() { 1, 2, 5, 4, 9, 3, 2, 1, 7, 10, 11, 15, 10 };
            
            for (int i=0; i<list.Count-1; i++)
            {
                for (int j = i+1; j <list.Count; j++)
                {
                   
                    if (list[i]==list[j])
                    {
                        Console.WriteLine(list[i]);
                    }
                   
                }
            }
            
          
        }

        public void Find_Dupbylinq()
        {
            List<String> list = new List<String> { "Sonal", "Amit", "Pooja", "Sonal", "Deepali", "Saurabh", "Pooja" };

            var dup = from a in list
                    group a by a into a
                    where a.Count() > 1
                    select a.First();

            foreach (var item in dup)
            {
                Console.WriteLine(item);

            }
        }

        public void Max_MinList()
        {
            List<int> list = new List<int>() { 1, 2, 5, 4, 9, 3, 2, 1, 7, 10, 11, 15, 10 };
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Max_MinList();
          //  //reverse of list
          //  //List<int> arr = new List<int>{ 1, 2, 3, 2, 4, 5, 6, 3, 9, 4, 7, 10, 15 };
          //int[]  arr = { 1, 2, 3, 2, 4, 5, 6, 3, 9, 4, 7, 10, 15 };
          //  //  Array.Reverse(arr);
          //  int[] arr2 = new  int[arr.Length];
          //  Array.Copy(arr,arr2,arr.Length);

          //  foreach (var a in arr2)
          //  {
          //      Console.WriteLine(a);
          //  }

          //  //List<int> arr = new List<int>{ 1, 2, 3, 2, 15, 5, 6, 3, 10, 4, 7, 10, 15 };

          //  //for (int i = 0; i < arr.Count; i++)
          //  //{
          //  //    for (int j = i+1; j < arr.Count; j++)
            //    {
            //        if (arr[i]==arr[j])
            //        {
            //            Console.WriteLine(arr[i]);
            //        }
            //    }
            //}
            Console.ReadLine();
        }
    }
    
}
