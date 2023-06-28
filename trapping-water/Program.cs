/*Best Solution is the typical put one pointer at the beginning and one at the end. While the beginning
does not exceed the end pointer which signifies they have met in the middle. We will run computations that
check if leftMax is less than the left element. If it is, then that means left has a new wall that could
hold water. If leftMax is bigger than left element that means there is a container of water which we
will compute into a counter. We will do this at the left and right side simulatenously. Time complexity
should be O(n) because we are only looping through the array proporationaly */

using System;

namespace TrappingWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = {0,1,0,2,1,0,1,3,2,1,2,1};
            int answer = GetSolution(height);
            Console.WriteLine(answer);
        }
        static int GetSolution(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            int rightMax = 0;
            int leftMax = 0;
            int counter = 0;

            while(left < right){
                if(array[left] <= array[right]){
                    if(array[left] < leftMax){
                        counter += leftMax - array[left];
                    } else {
                        leftMax = array[left];
                    }
                    left++;
                } else {
                    if(array[right] < rightMax){
                        counter += rightMax - array[right];
                    } else {
                        rightMax = array[right];
                    } right--;
                }
            } return counter;
        }
    }
}