using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            List<int> seenBefore = new();

            foreach (var item in nums)
            {
                if (seenBefore.Contains(item))
                {
                    return true;
                }
                else
                {
                    seenBefore.Add(item);
                }
            }

            return false;
        }
    }
}