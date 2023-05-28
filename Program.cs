//This is comment to my code

//rakendus küsib kasutajal sisestada tema nimi
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");
//string intterpolation

Console.WriteLine($"Hello {userName} !");