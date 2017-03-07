using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int[] ArrayInt=new int[]{2,3,4,3,8,2,4};
            Solution solu=new Solution();
            var result=solu.SingleNumber(ArrayInt);
            
            Console.WriteLine(result);
        }
        
        public class Solution {
            public int SingleNumber(int[] nums) {
                int result=0;
                for(var i=0;i<nums.Length;i++)
                {
                    result^=nums[i];
                }
                return result;
                
            }
        }
    }
    
}
