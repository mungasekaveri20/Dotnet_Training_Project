using System;

namespace matrix
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i,j;
            int m=3,n=3;
            
            int [,] arr={{1,2,3},{4,5,6},{8,9,9}};
            int [,]arr1={{5,9,8},{7,6,5},{4,3,2}};
            int[,] add=new int[m,n];
            int[,] sub=new int[m,n];
            int[,] div=new int[m,n];
            int[,] mult=new int[m,n];
            
            for(i=0;i<m;i++){
                for(j=0;j<n;j++){
                    //Console.ReadLine(); 
                    add[i,j]=arr[i,j]+arr1[i,j]; 
                    sub[i,j]=arr[i,j]-arr1[i,j]; 
                    mult[i,j]=arr[i,j]*arr1[i,j]; 
                    div[i,j]=arr[i,j]/arr1[i,j]; 
                }
            }
            Console.WriteLine("Addition of matrix : ");
            for(i=0;i<m;i++){
                for(j=0;j<n;j++){
                    //Console.ReadLine(); 
                    Console.WriteLine(add[i,j]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Substraction of matrix : ");
            for(i=0;i<m;i++){
                for(j=0;j<n;j++){
                    //Console.ReadLine(); 
                    Console.WriteLine(sub[i,j]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Multiplication of matrix : ");
            for(i=0;i<m;i++){
                for(j=0;j<n;j++){
                    //Console.ReadLine(); 
                    Console.WriteLine(mult[i,j]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Division of matrix : ");
            for(i=0;i<m;i++){
                for(j=0;j<n;j++){
                    //Console.ReadLine(); 
                    Console.WriteLine(div[i,j]);
                    
                }
                Console.WriteLine();
            }

        }
    }
}
