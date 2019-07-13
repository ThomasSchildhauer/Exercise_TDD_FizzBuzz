namespace Exercise_TDD_FizzBuzz
{
    public class FizzBuzz
    {
        public string DetermineFizzBuzz(int number)
        {  
            if(number != 0 && number%5 == 0 && number%3 == 0)
            {
                return "FizzBuzz";
            }
            if(number != 0 && number%3 == 0)
            {
                return "Fizz";
            }
            if(number != 0 && number%5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
