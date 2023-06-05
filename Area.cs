using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Area
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            var leftPointer = 0;
            var rightPointer = height.Length - 1;

            while (rightPointer > leftPointer)
            {
                var width = Math.Min(height[leftPointer], height[rightPointer]);
                var length = rightPointer - leftPointer;
                maxArea = Math.Max(maxArea, width * length);

                if (height[leftPointer] < height[rightPointer])
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }
            }

            return maxArea;
        }
    }
}