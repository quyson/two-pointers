/*Brute force answer is to check every number combination for every number which would be O(n^2). Better solution
is to perform the typical two pointer technique in which each pointer is initialized at the beginning and at the
end. Then, while looping through the array, compute the minimum height of both pointers because that is the limit
of the water container. Afterwards, store area of two pointers into a variable. Then move left or right pointer
according to < > comparison between the two values. Rerun said functionality and replace biggest area variable if 
necessary. Continue until the while loop stops and the biggest value should be found. Time complexity is
O(n) because the array is being looped through once and increases proportionately. Space Complexity is O(1)
because there is nothing additional being proportionately allocated in memory */


using System;

namespace Mostwater
{
    class Program
    {
        static void Main(string[] args){
            int[] array = {1,8,6,2,5,4,8,3,7};
            int answer = GetSolution(array);
            Console.WriteLine(answer);
        }
        static int GetSolution(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            int biggest = 0;

            while(left < right){
                int minimum = Math.Min(array[left], array[right]);
                int area = minimum * (right - left);
                biggest = Math.Max(area, biggest);
                if(array[left] < array[right]){
                    left++;
                } else {
                    right--;
                }
            }
            return biggest;
        }
    }
}