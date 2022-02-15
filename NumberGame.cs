using System;
public class NumberGame{
    private string[] numberArray;
    private int lengthArray;

    //constructor
    public NumberGame(int lengthArray){
        numberArray = CreateArray(lengthArray);
        this.lengthArray = lengthArray;
    }
    private string[] CreateArray(int lengthArray){
        string[] array = new string[lengthArray];
        for(int i = 0; i < lengthArray; i++){
            int number = i + 1;
            array[i] = number.ToString();
        }
        return array;
    }

    public void AddNewRule(string newValue, int number){
        for(int i = number - 1; i<lengthArray; i += number){
            int numberCheckValue;
            bool numberCheck = int.TryParse(numberArray[i], out numberCheckValue);
            if(!numberCheck){
                string oldValue = numberArray[i];
                numberArray[i] = oldValue + newValue;
            }
            else{
                numberArray[i] =  newValue;
            }
        }
    }
    public string[] CreatGame(){
        return numberArray;
    }
    public void PrintResult(string[] resualt, bool increase){
        if(increase){
            for(int i = 0; i < resualt.Length; i++){
                Console.WriteLine(resualt[i]);
            }
        }
        else{
            for(int i = resualt.Length - 1; i >= 0; i--){
                Console.WriteLine(resualt[i]);
            }
        }
    }
}