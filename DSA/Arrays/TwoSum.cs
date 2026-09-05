using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.Arrays
{
    public class TwoSum
    {
        public bool twoSum(int[] arr, int target)
        {

            // Brute Force Approach
            //int n = arr.Length;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] + arr[j] == target)
            //        {
            //            return true;
            //        }
            //    }
            //}

            //return false;

            
            // --------------------------------------------------------------------------------------------------------------'

            // Optimized Approach

            HashSet<int> seen = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (seen.Contains(complement))
                {
                    return true;
                }
                seen.Add(arr[i]);
            }
            return false;
        }

    }

}


//| Approach    |  Time | Space |

//| Brute force | O(n²) | O(1) |
//| HashSet     | O(n) average | O(n) |

//This is the classic time - space tradeoff:

//We use extra memory to reduce the running time.


//⚡ Why HashSet and not Dictionary?

//Good distinction to remember.

//HashSet

//Use when you only care about:

//Does this value exist?

//HashSet<int> seen = new();
//Dictionary

//Use when you care about:

//Value → associated information

//For example:

//Dictionary<int, int> frequencies = new();

//where:

//number → frequency

//or:

//number → index

//In the current problem we only need existence.

//Therefore:

//HashSet<int> ✅
//Dictionary<int, int> unnecessary