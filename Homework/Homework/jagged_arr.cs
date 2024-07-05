using System;
namespace jagged_arr{
class jagged_arr{
    static void Main(string[] args){
    
        int[][] arr=new int[3][];
        arr[0]=new int[] {1,2,3,4};
        arr[1]=new int[] {1,2,3};
        arr[2]=new int[] {1,3,3,4,7,3,9};

        Console.WriteLine("\nJagged Array ::::\n");
        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<arr[i].Length;j++){
                Console.Write(arr[i][j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nThank You .... !");
    }
}
}