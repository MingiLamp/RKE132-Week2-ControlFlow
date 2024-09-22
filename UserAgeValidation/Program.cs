// See https://aka.ms/new-console-template for more information

//Rakendus kysib kasutajal valida sugu m/f
//rakendus kysib kasutajal sisestada tema perekonnanime
//lahtudes kasutaja valikust, rakendus tervitab kasutajat jargmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms, []"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (s6ne) formaadis

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
