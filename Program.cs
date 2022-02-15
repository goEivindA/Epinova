namespace Epinova
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGame fizzBuzz = new NumberGame(100);
            fizzBuzz.AddNewRule("Fizz", 3);
            fizzBuzz.AddNewRule("Buzz", 5);
            string[] fizzBuzzResualt = fizzBuzz.CreatGame();
            fizzBuzz.PrintResult(fizzBuzzResualt, true);

            NumberGame JazzFuzz = new NumberGame(100);
            JazzFuzz.AddNewRule("Jazz", 9);
            JazzFuzz.AddNewRule("Fuzz", 4);
            string[] jazzFuzzResualt = JazzFuzz.CreatGame();
            JazzFuzz.PrintResult(jazzFuzzResualt, false);
        }
    }
}
