using System;
public class Jazzfuzz{
    //variables
    private string[] numberArray;
    private int lengthArray;
    //constructor
    public Jazzfuzz(int lengthArray){
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
    //Jazz and Fuzz functions
    public void jazzFuzzPrint(){
        string[] arrayResualt = numberArray;
        addJazzAndFuzz(arrayResualt);
        for(int i = arrayResualt.Length - 1; i >= 0; i--){
            Console.WriteLine(arrayResualt[i]);
        }
    }
    private void addJazzAndFuzz(string[] array){
        jazz(array);
        fuzz(array);
    }
    private void jazz(string[] array){
        for(int i = 8; i < array.Length; i+=9){
            array[i] = "Jazz";
        }
    }
    private void fuzz(string[] array){
        for(int i = 3; i < array.Length; i+=4){
            int number;
            bool numberCheck = int.TryParse(array[i], out number);
            if(!numberCheck){
                array[i] = "JazzFuzz";
            }
            else{
                array[i] = "Fuzz";
            }
        }
    }
}