/*The solution is utilizing the concept of two pointers. Basically, there are two points that we initialize and
keep track of. We then move each pointer when a condition is met, and will return an answer once a point has been
reached. We have a while loop to run through the string starting from the beginning and the end checking if both
are the same. If, not then the string is not a palindrome. Time Complexity should be O(n) because we're only 
looping through the string because it's technically only 1 loop but with two pointers/positions. At worse case,
which is if the word is a palindrome, we would loop through 1/2 of the string's length which would still be
simplified to O(n). Space is O(1) because we're not dedicating any new space to solving this */


using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word = "raddefgg";
            bool answer = getSolution(word);
            Console.WriteLine(answer);
        }
        static bool getSolution(string word)
        {   
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            int i = 0;
            int j = word.Length - 1;

            while(i != j){

                while(!r.IsMatch(word[i].ToString())){
                    i++;
                }
                while(!r.IsMatch(word[j].ToString())){
                    j--;
                }
                if(word[i].ToString() != word[j].ToString()){
                    return false;
                } else {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}