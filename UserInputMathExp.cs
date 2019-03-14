using System;

namespace UserInputMath{
	public class UserInputMathExp{
		//int result=0;
		public static void Main(){
			Add();  
		}
		public static int Add(){
			
		 int a,b,result=0;
		Console.WriteLine("Enter The First Number");
		a=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter The Second Number");
		b=int.Parse(Console.ReadLine());
		result=a+b;
		Console.WriteLine("My Result:"+result);
		
		return result;
		}
		
		}
}