using System;
namespace ConditionDemo
{
    public class ValidAge
    {
        public static void Main(){
            int age;
            Console.WriteLine("Enter the Age ");
            age=int.Parse(Console.ReadLine());
            GetAge(age);
        }
        public static void GetAge(int a){
            if(a>=18){
                Console.WriteLine("Valid Age for Voting");
            }else{
                Console.WriteLine("Not Valid Age For Voting");
            }
        }
    }
}