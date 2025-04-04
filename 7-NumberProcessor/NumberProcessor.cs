int initialNumber = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while (command != "End")
{
    switch (command)
    {
        case "Inc":
            initialNumber++;
            break;
        case "Dec":
            initialNumber--;
            break;        
    }    
    command = Console.ReadLine();
}

Console.WriteLine(initialNumber);