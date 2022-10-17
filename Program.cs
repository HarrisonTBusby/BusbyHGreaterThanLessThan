//Harrison Busby
//10/17/2022
//Mini Challenge 4
//Greater than or Less Than

string numbOne;
string numbTwo;
int numberOne;
int numberTwo;
bool trueNum1 = true;
bool trueNum2 = true;
string playAgain = "yes";

while(playAgain == "yes"){

Console.WriteLine("Hey give me a number!");
numbOne = Console.ReadLine();
trueNum1 = Int32.TryParse(numbOne, out numberOne);

Console.WriteLine("Hey give me another number!");
numbTwo = Console.ReadLine();
trueNum2 = Int32.TryParse(numbTwo, out numberTwo);

if(trueNum1 ==true && trueNum2 == true){

if(numberOne < numberTwo){
    Console.WriteLine(numberOne + " is less than " + numberTwo);
    Console.WriteLine(numberTwo + " is greater than " + numberOne);
    }else if(numberOne > numberTwo){
        Console.WriteLine(numberOne + " is greater than " + numberTwo);
        Console.WriteLine(numberTwo + " is less than " + numberOne);
    }else{
        Console.WriteLine(numberOne + " is equal to " + numberTwo);
    }
}else{
    Console.WriteLine("Please input a valid response");
}

    Console.WriteLine("Play again?");
    playAgain = Console.ReadLine();
    if(playAgain == "yes"){
        Console.WriteLine("Lets play again.");
    }else{
        Console.WriteLine("Go away.");
    }
}
