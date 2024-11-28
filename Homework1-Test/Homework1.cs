namespace Homework1_Test
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            string firstName = "Cristina";
            string lastName = "Filipan";
            int age = 34;
            string gender = "Female"; 
            int futureAge = age + 20;

            Console.WriteLine("Your details are as follows:");
            Console.WriteLine($"     - First Name: {firstName}");
            Console.WriteLine($"     - Last Name: {lastName}");
            Console.WriteLine($"     - Gender: {gender}");
            Console.WriteLine($"You will be {futureAge} years old in 20 years!");
        }
    }
}