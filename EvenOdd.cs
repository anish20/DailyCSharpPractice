//Write C# program check weather the enter the number is Even Or Odd.
// Problem Solution	=> Here if  given number divisible by 2 with reminder 0 then number is an even number,if number is not divisibleby 2 with not 0 it will odd number.

using System;
namespace EvenOddExampleProgram{
	public class EvenOdd{
		public static void Main(){
			int num;
			Console.WriteLine("Enter the Number");
			num=Convert.ToInt32(Console.ReadLine());
			if(num%2==0){
				Console.WriteLine("Entered Number is Even");
			}else{
				Console.WriteLine("Entered Number is Odd");
			}
			
		}
	}
}
// =====================================
// Output: 8 is even number
// Output: 5 is Odd Number.