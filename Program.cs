//Shaun Aguirre-Reyes
//10/17/22
//3:02pm
//This is just a simple conversation where the computer asks a question then reads the users input


Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){

Console.WriteLine("What is Your Name?");

string myName = Console.ReadLine();

Console.WriteLine("Good Afternoon " + myName);

Console.WriteLine("What time did you wake up at?");

string Time = Console.ReadLine();

Console.WriteLine("Wow you woke up at " + Time + ", thats amazing to hear " + myName + " I hope you have an amazing day :)");

Console.WriteLine("Would you like to talk again?");
playAgain = Console.ReadLine();
if(playAgain == "yes"){
    Console.WriteLine("Lets play again");
}else{
    Console.WriteLine("Have a great day :)");
}

}