using System;
public class FizzBuzz {
    //variables
    private string[] numberArray;
    private int lengthArray;
    //constructor
    public FizzBuzz(int lengthArray){
        numberArray = createArray(lengthArray);
        this.lengthArray = lengthArray;
    }
    //functions
    private string[] createArray(int lengthArray){
        string[] array = new string[lengthArray];
        for(int i = 0; i < lengthArray; i++){
            int number = i + 1;
            array[i] = number.ToString();
        }
        return array;
    }
    //FizzBuzz functions
    public void fizzBuzzPrint(){
        string[] arrayResualt = numberArray;
        addFizzAndBuzz(arrayResualt);
        for(int i = 0; i < arrayResualt.Length; i++){
            Console.WriteLine(arrayResualt[i]);
        }
    }
    private void addFizzAndBuzz(string[] array){
        fizz(array);
        buzz(array);
    }
    
    private void fizz(string[] array){
        for(int i = 2; i < array.Length; i+=3){
            array[i] = "Fizz";
        }
    }
    private string[] buzz(string[] array){
        for(int i = 4; i < array.Length; i+=5){
            int number;
            bool numberCheck = int.TryParse(array[i], out number);
            if(!numberCheck){
                array[i] = "FizzBuzz";
            }
            else{
                array[i] = "Buzz";
            }
        }
        return array;
    }
}