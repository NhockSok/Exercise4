using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   public  class Program
    {
       //input :float x
       //output : int a that is smallest but not smaller than a
       //idea : a = (int) x then a=a+1\
       //if : x negative then a is unchanged
       //if x==a then a is unchanged
       public static void Main(string[] args)
        {
        }
        public static int Ceil(float x)
        {    
           /*  if(x<0)  
            
                return (int)x;

            return ((int)x) + 1;   
            */
            int a = (int)x;
            if(x>0)
                if(x>a)
                a = a + 1;
            return a;

        }
       //input: float y
        //output : int a that is largest but not smaller than a
        //idea : a = (int) x then a=a-1
        //if : x negative then a is unchanged
        //if x==a then a is unchanged
       public static int Floor(float y)
        {
            int a = (int)y;
            if (y < 0 && y!=a)              
                    a = a - 1;                
            return a;
        }

       
    }
}
