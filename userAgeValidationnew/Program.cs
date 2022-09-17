//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis rakendusest kuvatakse "You are too young to use Instagram"
//muul juhul
//rakenduses kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int userAge = int.Parse(Console.ReadLine());//"13"- Heap, 13-stack


if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");
}