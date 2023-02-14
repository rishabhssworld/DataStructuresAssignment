import java.util.*;

public class AA2
{
    char[] a = new char[1];
    int occupancy=0;
   
    public AA2(){}

    public AA2(int length)
    {
        a = new char[length];
    }

    public int Occupancy()
    {
        return occupancy;
    }
    public char get(int i)
    {
        return a[i];
    }

    public char set(int i, char x)
    {
        char y = a[i];
        a[i] = x;
        return y;
    }

    public void add(int i, char x)
    {
        if(occupancy+1>a.length)
        {
            resize();
        }
        for(int j = occupancy; j>i; j--)
        {
            a[j]= a[j-1];
        }
        a[i]=x;
        occupancy++;
    }

    public char remove(int i)
    {
        char x = a[i];
        for(int j=i; j<occupancy-1; j++)
        {
            a[j] = a[j+1];
        }
        occupancy--;
        if(a.length >= 3*occupancy) resize();
        return x;
    }

    public void resize()
    {
        char[] b = new char[(Math.max(occupancy*2,1))];
        for(int i=0; i<occupancy; i++){
            b[i]= a[i];
        }
    }

    public static void main(String[] args)
    {
        AA2 arrayy = new AA2(6);
        arrayy.add(0,'b');
        arrayy.add(1,'r');
        arrayy.add(2,'e');
        arrayy.add(3,'d');
        for(int i = 0; i< arrayy.Occupancy(); i++)
        {
            System.out.print("["+arrayy.get(i)+"]");
        }

  
    }
}
