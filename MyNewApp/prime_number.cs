using System;
class PrimeNo{
    public static void Main(string[] args){

//prim number....

        Console.WriteLine("Enter the number till what you want prime numbers:");
        int num = int.Parse(Console.ReadLine());
        for(int i = 2; i<=num; i++){
            bool isPrime = true;
            for(int j = 2; j<=Math.Sqrt(i); j++){
                if(i%j==0){
                    isPrime = false;
                }
            }
            if(isPrime){
            Console.WriteLine(i);
        }
        }

//swapping...............
        // Console.WriteLine("Enter first number : ");
        // int a = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter second number : ");
        // int b = int.Parse(Console.ReadLine());
        // //int c =a+b;
        // Console.WriteLine("------------");
        // a=a+b;
        // b=a-b;
        // a=a-b;
        // Console.WriteLine(a);
        // Console.WriteLine(b);


        //factorial................
        // int b=1;
        // Console.WriteLine("Enter a number : ");

        // int a =  int.Parse(Console.ReadLine());
        // for(int i=1;i<=a;i++){
        //     b=b*i;
        //     //i--;
        // }
        // Console.WriteLine(b);


        //fibinacci..............

        




    }
}