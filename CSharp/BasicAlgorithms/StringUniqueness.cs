using CSharpBasics.Helpers;

namespace CSharpBasics;

/* 
* evaluate string chars uniquesness
* abc return true
* abac returns false
*/

public static partial class BasicAlgorithms
{
    public static bool IsUnique(this string toEvaluate)
    {        
        var characters = new List<char>();

        for(int i = 0; i < toEvaluate.Length; i++)
        {
            char c = toEvaluate[i];
            if(characters.Contains(c))
            {
                return false;
            }

            characters.Add(c);
        }

        return true;
    }
}
