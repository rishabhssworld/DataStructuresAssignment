public class ArrayResize 
{

    public void printarray(int[] arr)
    {
        for(int i=0; i<arr.length; i++)
        {
            System.out.print(arr[i]+" ");
        }
        System.out.println();
    }

    public static int[] resize(int[] arr, int capacity)
    {
        int[] temp = new int[capacity];

        for(int i=0; i<arr.length; i++)
        {
            temp[i] = arr[i];
        }
        return temp;
    }
    public static void main(String[] args)
    {
        int[] original = {5,1,2,9,10};

        System.out.println("the size of the original array: "+original.length);

        //size after resizing
        int[] x=resize(original,10);
        System.out.println("The size of the array after resizing: "+ x.length );

    }
    
}
