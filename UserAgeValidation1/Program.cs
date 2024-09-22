// See https://aka.ms/new-console-template for more information

//rakendus kysib kasutajal sisestada tema vanuse
//kui kasutaja vanuson vaiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use this app"
//muul juhul
//konsoolis kuvatakse "Welcome to app"
// kasutan naites toodud instagrami asemel app kuna lyhem sona  ja naitena sobiv xD

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); //"13" -heap, 13 - stack

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old");


if (isAgeNumber == true)
{
    if (userAgeNum > 13)
    {
        Console.WriteLine("Welcome to App");
    }
    else
    {
        Console.WriteLine("You are too young to use thus App.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}
