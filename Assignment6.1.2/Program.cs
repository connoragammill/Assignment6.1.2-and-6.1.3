namespace Assignment6._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Move all 0s in the array and maintain the order
            //example: [0,1,0,2,3,0,4]
            //result: [1,2,3,4,0,0,0]
            //Use a two-pointer method 

            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeros(nums);
            Console.WriteLine("Output: [" + string.Join(",", nums) + "]");
        }
        static void MoveZeros(int[] nums)
        {
            int nonZeroIndex = 0; //Initialize pointer for non-zero elements
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)//If nums is not equal to 0, then place them up front
                {
                    nums[nonZeroIndex] = nums[i];
                    nonZeroIndex++;
                }
            }
            for (int i = nonZeroIndex; i < nums.Length; i++)//Fill the rest of the array with zeros
            {
                nums[i] = 0;
            }
		}
    }
}
