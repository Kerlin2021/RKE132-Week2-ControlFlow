// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt sisestada tema vanus
//kui kasutaja vanus on väikem kui 13, siis konsoolis kuvatakse:
//"you are too young to use instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int userAge =Int32.Parse(Console.ReadLine()); 

if(userAge > 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are to young to use Instagram!");
}