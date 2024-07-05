using System;
class Insertion{
    public static void Main(string[] args){
        int[] arr={6,5,2,7,3};
        for(int i=1;i<arr.Length;i++){
            for(int j=i;j>0 && arr[j]<arr[j-1];j--){
                int temp=arr[j];
                arr[j]=arr[j-1];
                arr[j-1]=temp;
            }
        }

        for(int i=0;i<=arr.Length-1;i++){
            Console.WriteLine(arr[i]);
        }
}
}