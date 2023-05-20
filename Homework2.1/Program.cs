using System;  
public class Exercise33 
{  
    public static void Main()
{
    int no_row,c=1,blk,i,j;

    no_row = Convert.ToInt32(Console.ReadLine());
     if (no_row >= 0) {   
    	
    for(i=0;i<no_row;i++)
    {
        for(blk=1;blk<=no_row;blk++)
        Console.Write("  ");
        for(j=0;j<=i;j++)
        {
            if (j==0||i==0)
                c=1;
            else
               c=c*(i-j+1)/j;
            Console.Write("{0}   ",c);
        }
        Console.Write("\n"); 
    }
    } while (no_row < 0) {
         Console.WriteLine("Invalid Pascal’s triangle row number.");
          no_row = Convert.ToInt32(Console.ReadLine());
          if (no_row >= 0) {   
    	
    for(i=0;i<no_row;i++)
    {
        for(blk=1;blk<=no_row;blk++)
        Console.Write("  ");
        for(j=0;j<=i;j++)
        {
            if (j==0||i==0)
                c=1;
            else
               c=c*(i-j+1)/j;
            Console.Write("{0}   ",c);
        }
        Console.Write("\n"); 
    }
    
  }	
}
}
}
