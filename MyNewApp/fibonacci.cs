using System;
namespace myprog{
    public class prog{
        public static void Main(string[] args){
            int f=0,s=1,m;
            Console.WriteLine("Enter a number : ");
            int a = int.Parse(Console.ReadLine());
            for(int i=0;i<a;i++){
                    if(i<=1){
                        m=i;
                    }
                    else{
                        m=f+s;
                        f=s;
                        s=m;
                    }
                    Console.WriteLine(m+" ");
            }
        }
    }
}