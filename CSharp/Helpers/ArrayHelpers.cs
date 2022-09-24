namespace CSharpBasics.Helpers;

public static class ArrayHelpers
{
/* 
*   this is a helper method
*   known as a method "extension"
*   using a STATIC METHOD, accepting an arguement
*   "THIS" and a TYPE (primitives (int, bool, etc.), 
*                       or custom Types IE class MyClass
*                       or Enums etc.)
*   enable us to do a dot walk on a TYPE
*   ex: for an int, you could say 
*
*   static void PrintInt(this int toPrint)
*   {
*       Console.WriteLine(toPrint);
*   }
*   
*   could be used like this
*   13.PrintInt();
*   output: 13
*
*   custom class ex:
*
*   class MyClass { int SomeIntProp { get; set; }  }
*
*   static void PrintInt(this MyClass toPrint)
*   {
*       Console.WriteLine(toPrint.SomeIntProp);
*   }
*
*   could be used like this
*   var thirteen = new MyClass();
*   thirteen.SomeIntProp = 13;
*   thirteen.PrintInt();
*   output: 13
*
*   this method extension
*   creates a new array from an old array and adds a new value 
*/
    public static int[] AddValue(this int[] oldArray, int newValue)
    {
        /* 
        *  when creating arrays we must either  
        *  specify the "size" aka length 
        *  ex: new int[5] -- this array is 5 elements long, 
        *           though the values are defaulted to 0 
        *  or specify the values like   
        *  ex: new int[]{1,2,3,4,5} -- this is also 5 elements long
        *           though the values are set as [1,2,3,4,5]
        */
        int newSize = oldArray.Length + 1;
        int[] newArray = new int[newSize];

        if(oldArray.Length > 0)
        {
            for (int iterator = 0; iterator < oldArray.Length; iterator++)
            {
                newArray[iterator] = oldArray[iterator];
            }
        }

        int lastPositionNewArray = newSize - 1;
        newArray[lastPositionNewArray] = newValue;
        return newArray;
    }
}