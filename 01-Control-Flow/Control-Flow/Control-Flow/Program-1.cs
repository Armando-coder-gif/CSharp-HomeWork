

void Main()
{
    Console.WriteLine("Type a number: ");
    var inputUser = Console.ReadLine();

    while (true)
    {
        // if inputUser is numeric
        // I use this way because the homework use from 1 to 10
        if (int.TryParse(inputUser, out _))
        {
            
            if(Convert.ToInt32(inputUser) >=1 && Convert.ToInt32(inputUser) <= 10)
            {
                Console.WriteLine("Valid");
                break;
            }
            else
            {
                Console.WriteLine("Invalid");
                break;
            }
            
        }
        else
        {
            Console.WriteLine("Type a number: ");
            inputUser = Console.ReadLine();
        }

    }
}

Main();