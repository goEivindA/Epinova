namespace Epinova
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz(100);
            fizzBuzz.fizzBuzzPrint();
            Jazzfuzz jazzfuzz = new Jazzfuzz(100);
            jazzfuzz.jazzFuzzPrint();
        }
    }
}
