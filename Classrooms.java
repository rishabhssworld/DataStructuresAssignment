package Heaps;
import java.util.*;

public class Classrooms 
{
    static class Heap
    {
        ArrayList<Integer> arr = new ArrayList<>();

        public void add(int data) //O(logn)
        {
            //add at last index
            arr.add(data);

            int x = arr.size()-1; //x is child index
            int par = (x-1)/2; //parent index

            while(arr.get(x) < arr.get(par)) //O(logn)
            {
                //swap
                int temp = arr.get(x);
                arr.set(x,arr.get(par));
                arr.set(par,temp);

                // update indices
                x = par;
                par = (x-1)/2;
            }
        }
        public void printHeap() 
        {
            System.out.println(arr);
        }
    }
    public static void main(String[] args)
    {
        Heap minHeap = new Heap();

        minHeap.add(4);
        minHeap.add(9);
        minHeap.add(6);
        minHeap.add(17);
        minHeap.add(26);
        minHeap.add(8);
        minHeap.add(16);
        minHeap.add(19);
        minHeap.add(69);
        minHeap.add(32);
        minHeap.add(93);
        minHeap.add(55);
        minHeap.add(50);
        minHeap.printHeap();
        minHeap.add(7);
        minHeap.printHeap();
        minHeap.add(3);
        minHeap.printHeap();
    }
    
}
