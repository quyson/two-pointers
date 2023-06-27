/* First Solution involves running through the loop and then checking each number for every iteration which
is a brute force method and will be Time O(n^2) 

Second Solution involves setting one pointer at the beginning and one pointer at the end. Since the array is 
ordered, logically if the sum of both pointers is lower than the target, we can move the first pointer up 1. And if
the target is less than the sum then we can move the pointer at the end down 1 until we reach a set of numbers
that equal the sum. Time should be O(n) since we would be running through the array once with two pointers.*/

using System;

namespace TwoSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0,1,2,5,7,12};
            int target = 9;
            int[] ? answer = GetBetterSolution(numbers, target);
            if(answer != null){
                 Console.WriteLine("Indices: [{0}, {1}]", answer[0], answer[1]);
            } else {
                Console.WriteLine("No Answer");
            }
        }
        static int[]? Get1stSolution(int[] numbers, int target)
        {
            for(int i = 0; i < numbers.Length - 1; i++){
                int j = i + 1;
                while(j < numbers.Length && numbers[i] + numbers[j] < target){
                    j++;
                }
                if(numbers[i] + numbers[j] == target){
                    int[] answer = {i + 1, j + 1};
                    return answer;
                }     
            } return null;
        }
        static int[] ? GetBetterSolution(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            while(i != j){
                if(numbers[i] + numbers[j] < target){
                    i++;
                }
                if(numbers[i] + numbers[j] > target){
                    j--;
                }
                if(numbers[i] + numbers[j] == target){
                    int[] answer = {i + 1, j + 1};
                    return answer;
                }
            } return null;
        }
    }
}