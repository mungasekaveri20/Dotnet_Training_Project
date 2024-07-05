using System;

namespace EvenOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter a number :");
            // int a =int.Parse( Console.ReadLine());
            // for(int i=0;i<a;i++){
            //     Console.WriteLine(a);
            //     a--;
            //     // if(i==0){
            //     //     break;
            //     // }

            // }

            int[] arr={0,1,2,3,4,5,6,7,8,9};
            for(int i=arr.Length-1;i>=0;i--){
                //arr[i]--;
                Console.WriteLine(arr[i]);

            }

            
        }
    }
}
