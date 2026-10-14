Random rnd = new Random();
Random rnd2 = new Random();
string playerChoice = "";
int playerNumber = 0;
string name = " ";
do
{
    Console.Write("1-Human 2-Computer: ");
    playerChoice = Console.ReadLine();
    if (!int.TryParse(playerChoice, out playerNumber) || string.IsNullOrEmpty(playerChoice))
    {
        Console.WriteLine("Please enter a valid number");

    }
    else if (playerNumber > 2 || playerNumber < 0)
    {
        Console.WriteLine("Please enter a number between 1-2");
    }
} while ((!int.TryParse(playerChoice, out playerNumber) || string.IsNullOrEmpty(playerChoice)) || (playerNumber > 2 || playerNumber < 0));
string player = "";
switch (playerNumber)
{
    case 1:
        player = " Human";
        do
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalide name please enter your name again: ");
            }                
        } while (string.IsNullOrEmpty(name));
        break;
    case 2:
        player = " Computer";
        break;
}

char A = 'A';
char B = 'B';
char C = 'C';
char D = 'D';
char E = 'E';

string type = "";
int typeChoice = 0;

do
{
    Console.Write("Enter number of types of symbols between 1 - 5: ");
    type = Console.ReadLine();
    if (!int.TryParse(type, out typeChoice) || string.IsNullOrEmpty(type))
    {
        Console.WriteLine("Please enter a valid option");
    }
    else if (typeChoice > 5 || typeChoice < 1)
    {
        Console.WriteLine("Please enter a number between 1-5");
    }
} while ((typeChoice > 5 || typeChoice < 1));

string typeOfSymbols = "";

switch (typeChoice)
{
    case 1:
        typeOfSymbols = ($"{A}");
        break;
    case 2:
        typeOfSymbols = ($"{A},{B}");
        break;
    case 3:
        typeOfSymbols = ($"{A},{B},{C}");
        break;
    case 4:
        typeOfSymbols = ($"{A},{B},{C},{D}");
        break;
    case 5:
        typeOfSymbols = ($"{A},{B},{C},{D},{E}");
        break;
}

string numberChoice = "";
int number = 0;
do
{
    Console.Write("Enter number of symbols between 1 - 6: ");
    numberChoice = Console.ReadLine();
    if (!int.TryParse(numberChoice, out number) || string.IsNullOrEmpty(numberChoice))
    {
        Console.WriteLine("Enter a valid number");
    }
    else if (number > 6 || number < 1)
    {
        Console.WriteLine("Please Enter a number between 1-6");
    }
    else if (number < typeChoice)
    {
        Console.WriteLine("Number of symbols can not be less than number of types of symbols.");
    }

} while ((!int.TryParse(numberChoice, out number) || string.IsNullOrEmpty(numberChoice)) || (number > 6 || number < 1) || (number < typeChoice));

string shift = "";
int shiftNumber = 0;

do
{
    Console.Write("Enter a shift number between 1-20: ");
    shift = Console.ReadLine();
    if (!int.TryParse(shift, out shiftNumber) || string.IsNullOrEmpty(shift))
    {
        Console.WriteLine("Enter a valid nmber");
    }
    else if (shiftNumber > 20 || shiftNumber < 1)
    {
        Console.WriteLine("Please Enter a number between 1-20");
    }
} while ((!int.TryParse(shift, out shiftNumber) || string.IsNullOrEmpty(shift)) || (shiftNumber > 20 || shiftNumber < 1));



Console.WriteLine("Game Mode");
Console.WriteLine("-------------");
Console.WriteLine($"Player: {player}");
if (playerNumber == 1)
    Console.WriteLine($"Player name is: {name}");
Console.WriteLine($"Symbols: {typeOfSymbols}");
Console.WriteLine($"Number of symbols: {number}");
Console.WriteLine($"Number of shifts :{shiftNumber}");

char x1 = ' ';
char x2 = ' ';
char x3 = ' ';
char x4 = ' ';
char x5 = ' ';
char x6 = ' ';
char x7 = ' ';
char x8 = ' ';
char x9 = ' ';
 
char firstChar = 'A';
char secondChar = 'B';
char thirdChar = 'C';
char fourthChar = 'D';
char fifthChar = 'E';

int x = 0;
int a = 0;
int b = 0;
int c = 0;
int d = 0;
int e = 0;
int f = 0;

int round = 1;

if (number == 1)
{

    x = rnd.Next(1, 10);
    switch (x)
    {
        case 1:
            x1 = firstChar;
            break;
        case 2:
            x2 = firstChar;
            break;
        case 3:
            x3 = firstChar;
            break;
        case 4:
            x4 = firstChar;
            break;
        case 5:
            x5 = firstChar;
            break;
        case 6:
            x6 = firstChar;
            break;
        case 7:
            x7 = firstChar;
            break;
        case 8:
            x8 = firstChar;
            break;
        case 9:
            x9 = firstChar;
            break;
    }
}
else if (number == 2)
{
    if (typeChoice == 1)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
            switch (x)
            {
                case 1:
                    x1 = firstChar;
                    break;
                case 2:
                    x2 = firstChar;
                    break;
                case 3:
                    x3 = firstChar;
                    break;
                case 4:
                    x4 = firstChar;
                    break;
                case 5:
                    x5 = firstChar;
                    break;
                case 6:
                    x6 = firstChar;
                    break;
                case 7:
                    x7 = firstChar;
                    break;
                case 8:
                    x8 = firstChar;
                    break;
                case 9:
                    x9 = firstChar;
                    break;
            }
    }
    else if (typeChoice == 2)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
            switch (x)
            {
                case 1:
                    x1 = secondChar;
                    break;
                case 2:
                    x2 = secondChar;
                    break;
                case 3:
                    x3 = secondChar;
                    break;
                case 4:
                    x4 = secondChar;
                    break;
                case 5:
                    x5 = secondChar;
                    break;
                case 6:
                    x6 = secondChar;
                    break;
                case 7:
                    x7 = secondChar;
                    break;
                case 8:
                    x8 = secondChar;
                    break;
                case 9:
                    x9 = secondChar;
                    break;
            }
    }
}

else if (number == 3)
{
    if (typeChoice == 1)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
            b = x;
            switch (x)
            {
                case 1:
                    x1 = firstChar;
                    break;
                case 2:
                    x2 = firstChar;
                    break;
                case 3:
                    x3 = firstChar;
                    break;
                case 4:
                    x4 = firstChar;
                    break;
                case 5:
                    x5 = firstChar;
                    break;
                case 6:
                    x6 = firstChar;
                    break;
                case 7:
                    x7 = firstChar;
                    break;
                case 8:
                    x8 = firstChar;
                    break;
                case 9:
                    x9 = firstChar;
                    break;
            }
        do
        {
            x = rnd.Next(1, 10);
        }while (a == x || b == x);
            c = x;
            switch (x)
            {
                case 1:
                    x1 = firstChar;
                    break;
                case 2:
                    x2 = firstChar;
                    break;
                case 3:
                    x3 = firstChar;
                    break;
                case 4:
                    x4 = firstChar;
                    break;
                case 5:
                    x5 = firstChar;
                    break;
                case 6:
                    x6 = firstChar;
                    break;
                case 7:
                    x7 = firstChar;
                    break;
                case 8:
                    x8 = firstChar;
                    break;
                case 9:
                    x9 = firstChar;
                    break;
            }
    }
    else if (typeChoice == 2)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        }while (a == x);
        b = x;
            switch (x)
            {
                case 1:
                    x1 = secondChar;
                    break;
                case 2:
                    x2 = secondChar;
                    break;
                case 3:
                    x3 = secondChar;
                    break;
                case 4:
                    x4 = secondChar;
                    break;
                case 5:
                    x5 = secondChar;
                    break;
                case 6:
                    x6 = secondChar;
                    break;
                case 7:
                    x7 = secondChar;
                    break;
                case 8:
                    x8 = secondChar;
                    break;
                case 9:
                    x9 = secondChar;
                    break;
            }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
            c = x;
            switch (x)
            {
                case 1:
                    x1 = firstChar;
                    break;
                case 2:
                    x2 = firstChar;
                    break;
                case 3:
                    x3 = firstChar;
                    break;
                case 4:
                    x4 = firstChar;
                    break;
                case 5:
                    x5 = firstChar;
                    break;
                case 6:
                    x6 = firstChar;
                    break;
                case 7:
                    x7 = firstChar;
                    break;
                case 8:
                    x8 = firstChar;
                    break;
                case 9:
                    x9 = firstChar;
                    break;
            }    
    }
    else if (typeChoice == 3)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
            b = x;
            switch (x)
            {
                case 1:
                    x1 = secondChar;
                    break;
                case 2:
                    x2 = secondChar;
                    break;
                case 3:
                    x3 = secondChar;
                    break;
                case 4:
                    x4 = secondChar;
                    break;
                case 5:
                    x5 = secondChar;
                    break;
                case 6:
                    x6 = secondChar;
                    break;
                case 7:
                    x7 = secondChar;
                    break;
                case 8:
                    x8 = secondChar;
                    break;
                case 9:
                    x9 = secondChar;
                    break;
            }
        do
        {
            x = rnd.Next(1, 10);
        }while(a == x || b == x);
            c = x;
            switch (x)
            {
                case 1:
                    x1 = thirdChar;
                    break;
                case 2:
                    x2 = thirdChar;
                    break;
                case 3:
                    x3 = thirdChar;
                    break;
                case 4:
                    x4 = thirdChar;
                    break;
                case 5:
                    x5 = thirdChar;
                    break;
                case 6:
                    x6 = thirdChar;
                    break;
                case 7:
                    x7 = thirdChar;
                    break;
                case 8:
                    x8 = thirdChar;
                    break;
                case 9:
                    x9 = thirdChar;
                    break;
            }
    }
}
else if (number == 4)
{
    if (typeChoice == 1)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
        b = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
    }
    else if (typeChoice == 2)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
    }
    else if (typeChoice == 3)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
    }
    else if (typeChoice == 4)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = fourthChar;
                break;
            case 2:
                x2 = fourthChar;
                break;
            case 3:
                x3 = fourthChar;
                break;
            case 4:
                x4 = fourthChar;
                break;
            case 5:
                x5 = fourthChar;
                break;
            case 6:
                x6 = fourthChar;
                break;
            case 7:
                x7 = fourthChar;
                break;
            case 8:
                x8 = fourthChar;
                break;
            case 9:
                x9 = fourthChar;
                break;
        }
    }

}
else if (number == 5)
{
    if (typeChoice == 1)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
        b = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
    }
    else if (typeChoice == 2)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || e == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
    }
    else if (typeChoice == 3)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
    }
    else if (typeChoice == 4)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = fourthChar;
                break;
            case 2:
                x2 = fourthChar;
                break;
            case 3:
                x3 = fourthChar;
                break;
            case 4:
                x4 = fourthChar;
                break;
            case 5:
                x5 = fourthChar;
                break;
            case 6:
                x6 = fourthChar;
                break;
            case 7:
                x7 = fourthChar;
                break;
            case 8:
                x8 = fourthChar;
                break;
            case 9:
                x9 = fourthChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
    }
    else if (typeChoice == 5)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = fourthChar;
                break;
            case 2:
                x2 = fourthChar;
                break;
            case 3:
                x3 = fourthChar;
                break;
            case 4:
                x4 = fourthChar;
                break;
            case 5:
                x5 = fourthChar;
                break;
            case 6:
                x6 = fourthChar;
                break;
            case 7:
                x7 = fourthChar;
                break;
            case 8:
                x8 = fourthChar;
                break;
            case 9:
                x9 = fourthChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = fifthChar;
                break;
            case 2:
                x2 = fifthChar;
                break;
            case 3:
                x3 = fifthChar;
                break;
            case 4:
                x4 = fifthChar;
                break;
            case 5:
                x5 = fifthChar;
                break;
            case 6:
                x6 = fifthChar;
                break;
            case 7:
                x7 = fifthChar;
                break;
            case 8:
                x8 = fifthChar;
                break;
            case 9:
                x9 = fifthChar;
                break;
        }
    }

}
else if (number == 6)
{
    if (typeChoice == 1)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
        b = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x || e == x);
        f = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
    }
    else if (typeChoice == 2)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || e == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x || e == x);
        f = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
    }
    else if (typeChoice == 3)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x || e == x);
        f = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
    }
    else if (typeChoice == 4)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = fourthChar;
                break;
            case 2:
                x2 = fourthChar;
                break;
            case 3:
                x3 = fourthChar;
                break;
            case 4:
                x4 = fourthChar;
                break;
            case 5:
                x5 = fourthChar;
                break;
            case 6:
                x6 = fourthChar;
                break;
            case 7:
                x7 = fourthChar;
                break;
            case 8:
                x8 = fourthChar;
                break;
            case 9:
                x9 = fourthChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x || e == x);
        f = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
    }
    else if (typeChoice == 5)
    {
        x = rnd.Next(1, 10);
        a = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (x == a);
        b = x;
        switch (x)
        {
            case 1:
                x1 = secondChar;
                break;
            case 2:
                x2 = secondChar;
                break;
            case 3:
                x3 = secondChar;
                break;
            case 4:
                x4 = secondChar;
                break;
            case 5:
                x5 = secondChar;
                break;
            case 6:
                x6 = secondChar;
                break;
            case 7:
                x7 = secondChar;
                break;
            case 8:
                x8 = secondChar;
                break;
            case 9:
                x9 = secondChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x);
        c = x;
        switch (x)
        {
            case 1:
                x1 = thirdChar;
                break;
            case 2:
                x2 = thirdChar;
                break;
            case 3:
                x3 = thirdChar;
                break;
            case 4:
                x4 = thirdChar;
                break;
            case 5:
                x5 = thirdChar;
                break;
            case 6:
                x6 = thirdChar;
                break;
            case 7:
                x7 = thirdChar;
                break;
            case 8:
                x8 = thirdChar;
                break;
            case 9:
                x9 = thirdChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x);
        d = x;
        switch (x)
        {
            case 1:
                x1 = fourthChar;
                break;
            case 2:
                x2 = fourthChar;
                break;
            case 3:
                x3 = fourthChar;
                break;
            case 4:
                x4 = fourthChar;
                break;
            case 5:
                x5 = fourthChar;
                break;
            case 6:
                x6 = fourthChar;
                break;
            case 7:
                x7 = fourthChar;
                break;
            case 8:
                x8 = fourthChar;
                break;
            case 9:
                x9 = fourthChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x);
        e = x;
        switch (x)
        {
            case 1:
                x1 = fifthChar;
                break;
            case 2:
                x2 = fifthChar;
                break;
            case 3:
                x3 = fifthChar;
                break;
            case 4:
                x4 = fifthChar;
                break;
            case 5:
                x5 = fifthChar;
                break;
            case 6:
                x6 = fifthChar;
                break;
            case 7:
                x7 = fifthChar;
                break;
            case 8:
                x8 = fifthChar;
                break;
            case 9:
                x9 = fifthChar;
                break;
        }
        do
        {
            x = rnd.Next(1, 10);
        } while (a == x || b == x || c == x || d == x || e == x);
        f = x;
        switch (x)
        {
            case 1:
                x1 = firstChar;
                break;
            case 2:
                x2 = firstChar;
                break;
            case 3:
                x3 = firstChar;
                break;
            case 4:
                x4 = firstChar;
                break;
            case 5:
                x5 = firstChar;
                break;
            case 6:
                x6 = firstChar;
                break;
            case 7:
                x7 = firstChar;
                break;
            case 8:
                x8 = firstChar;
                break;
            case 9:
                x9 = firstChar;
                break;
        }
    }
}

char x11 = x1;
char x12 = x2;
char x13 = x3;
char x14 = x4;
char x15 = x5;
char x16 = x6;
char x17 = x7;
char x18 = x8;
char x19 = x9;

Console.WriteLine();

for (int i = 1; i <= shiftNumber; i++)
{

    int aiShift = rnd.Next(1, 13);

    if (aiShift == 1)
    {
        if (x13 == ' ' && x12 == ' ' && x11 != ' ')
        {
            x13 = x11;
            x11 = ' ';
        }
        if (x13 == ' ' && x12 != ' ')
        {
            x13 = x12;
            x12 = ' ';
        }
        if (x12 == ' ' && x11 != ' ')
        {
            x12 = x11;
            x11 = ' ';
        }
    }
    else if (aiShift == 2)
    {
        if (x16 == ' ' && x15 == ' ' && x14 != ' ')
        {
            x16 = x14;
            x14 = ' ';
        }
        if (x16 == ' ' && x15 != ' ')
        {
            x16 = x15;
            x15 = ' ';
        }
        if (x15 == ' ' && x14 != ' ')
        {
            x15 = x14;
            x14 = ' ';
        }
    }
    else if (aiShift == 3)
    {
        if (x19 == ' ' && x18 == ' ' && x17 != ' ')
        {
            x19 = x17;
            x17 = ' ';
        }
        if (x19 == ' ' && x18 != ' ')
        {
            x19 = x18;
            x18 = ' ';
        }
        if (x18 == ' ' && x17 != ' ')
        {
            x18 = x17;
            x17 = ' ';
        }
    }
    else if (aiShift == 4)
    {
        if (x11 == ' ' && x12 == ' ' && x13 != ' ')
        {
            x11 = x13;
            x13 = ' ';
        }
        if (x11 == ' ' && x12 != ' ')
        {
            x11 = x12;
            x12 = ' ';
        }
        if (x12 == ' ' && x13 != ' ')
        {
            x12 = x13;
            x13 = ' ';
        }
    }
    else if (aiShift == 5)
    {
        if (x14 == ' ' && x15 == ' ' && x16 != ' ')
        {
            x14 = x16;
            x16 = ' ';
        }
        if (x14 == ' ' && x15 != ' ')
        {
            x14 = x15;
            x15 = ' ';
        }
        if (x15 == ' ' && x16 != ' ')
        {
            x15 = x16;
            x16 = ' ';
        }
    }
    else if (aiShift == 6)
    {
        if (x17 == ' ' && x18 == ' ' && x19 != ' ')
        {
            x17 = x19;
            x19 = ' ';
        }
        if (x17 == ' ' && x18 != ' ')
        {
            x17 = x18;
            x18 = ' ';
        }
        if (x18 == ' ' && x19 != ' ')
        {
            x18 = x19;
            x19 = ' ';
        }
    }
    else if (aiShift == 7)
    {
        if (x17 == ' ' && x14 == ' ' && x11 != ' ')
        {
            x17 = x11;
            x11 = ' ';
        }
        if (x17 == ' ' && x14 != ' ')
        {
            x17 = x14;
            x14 = ' ';
        }
        if (x14 == ' ' && x11 != ' ')
        {
            x14 = x11;
            x11 = ' ';
        }
    }
    else if (aiShift == 8)
    {
        if (x18 == ' ' && x15 == ' ' && x12 != ' ')
        {
            x18 = x12;
            x12 = ' ';
        }
        if (x18 == ' ' && x15 != ' ')
        {
            x18 = x15;
            x15 = ' ';
        }
        if (x15 == ' ' && x12 != ' ')
        {
            x15 = x12;
            x12 = ' ';
        }
    }
    else if (aiShift == 9)
    {
        if (x19 == ' ' && x16 == ' ' && x13 != ' ')
        {
            x19 = x13;
            x13 = ' ';
        }
        if (x19 == ' ' && x16 != ' ')
        {
            x19 = x16;
            x16 = ' ';
        }
        if (x16 == ' ' && x13 != ' ')
        {
            x16 = x13;
            x13 = ' ';
        }
    }
    else if (aiShift == 10)
    {
        if (x11 == ' ' && x14 == ' ' && x17 != ' ')
        {
            x11 = x17;
            x17 = ' ';
        }
        if (x11 == ' ' && x14 != ' ')
        {
            x11 = x14;
            x14 = ' ';
        }
        if (x14 == ' ' && x17 != ' ')
        {
            x14 = x17;
            x17 = ' ';
        }
    }
    else if (aiShift == 11)
    {
        if (x12 == ' ' && x15 == ' ' && x18 != ' ')
        {
            x12 = x18;
            x18 = ' ';
        }
        if (x12 == ' ' && x15 != ' ')
        {
            x12 = x15;
            x15 = ' ';
        }
        if (x15 == ' ' && x18 != ' ')
        {
            x15 = x18;
            x18 = ' ';
        }
    }
    else if (aiShift == 12)
    {
        if (x13 == ' ' && x16 == ' ' && x19 != ' ')
        {
            x13 = x19;
            x19 = ' ';
        }
        if (x13 == ' ' && x16 != ' ')
        {
            x13 = x16;
            x16 = ' ';
        }
        if (x16 == ' ' && x19 != ' ')
        {
            x16 = x19;
            x19 = ' ';
        }
    }
}

Console.WriteLine("--- Target Board ---");
Console.WriteLine();
Console.WriteLine("   7  8  9  ");
Console.WriteLine(" +---------+");
Console.WriteLine($"1| {x11}  {x12}  {x13} |4");
Console.WriteLine($" |         | ");
Console.WriteLine($"2| {x14}  {x15}  {x16} |5");
Console.WriteLine($" |         | ");
Console.WriteLine($"3| {x17}  {x18}  {x19} |6");
Console.WriteLine(" +---------+");
Console.WriteLine("  10 11 12  ");

Console.WriteLine();
Console.WriteLine($"--- Round {round} ---");
Console.WriteLine();
Console.WriteLine("   7  8  9  ");
Console.WriteLine(" +---------+");
Console.WriteLine($"1| {x1}  {x2}  {x3} |4");
Console.WriteLine($" |         | ");
Console.WriteLine($"2| {x4}  {x5}  {x6} |5");
Console.WriteLine($" |         | ");
Console.WriteLine($"3| {x7}  {x8}  {x9} |6");
Console.WriteLine(" +---------+");
Console.WriteLine("  10 11 12  ");
round++;

Console.WriteLine();

int shiftchoicecounter = 1;
bool start = true;
while (start)
{
    Console.Write("Type a number: ");
    int shiftchoice = Convert.ToInt32(Console.ReadLine());

    if (shiftchoice == 1)
    {
        if (x3 == ' ' && x2 == ' ' && x1 != ' ')
        {
            x3 = x1;
            x1 = ' ';
        }
        if (x3 == ' ' && x2 != ' ')
        {
            x3 = x2;
            x2 = ' ';
        }
        if (x2 == ' ' && x1 != ' ')
        {
            x2 = x1;
            x1 = ' ';
        }
    }
    else if (shiftchoice == 2)
    {
        if (x6 == ' ' && x5 == ' ' && x4 != ' ')
        {
            x6 = x4;
            x4 = ' ';
        }
        if (x6 == ' ' && x5 != ' ')
        {
            x6 = x5;
            x5 = ' ';
        }
        if (x5 == ' ' && x4 != ' ')
        {
            x5 = x4;
            x4 = ' ';
        }
    }
    else if (shiftchoice == 3)
    {
        if (x9 == ' ' && x8 == ' ' && x7 != ' ')
        {
            x9 = x7;
            x7 = ' ';
        }
        if (x9 == ' ' && x8 != ' ')
        {
            x9 = x8;
            x8 = ' ';
        }
        if (x8 == ' ' && x7 != ' ')
        {
            x8 = x7;
            x7 = ' ';
        }
    }
    else if (shiftchoice == 4)
    {
        if (x1 == ' ' && x2 == ' ' && x3 != ' ')
        {
            x1 = x3;
            x3 = ' ';
        }
        if (x1 == ' ' && x2 != ' ')
        {
            x1 = x2;
            x2 = ' ';
        }
        if (x2 == ' ' && x3 != ' ')
        {
            x2 = x3;
            x3 = ' ';
        }
    }
    else if (shiftchoice == 5)
    {
        if (x4 == ' ' && x5 == ' ' && x6 != ' ')
        {
            x4 = x6;
            x6 = ' ';
        }
        if (x4 == ' ' && x5 != ' ')
        {
            x4 = x5;
            x5 = ' ';
        }
        if (x5 == ' ' && x6 != ' ')
        {
            x5 = x6;
            x6 = ' ';
        }
    }
    else if (shiftchoice == 6)
    {
        if (x7 == ' ' && x8 == ' ' && x9 != ' ')
        {
            x7 = x9;
            x9 = ' ';
        }
        if (x7 == ' ' && x8 != ' ')
        {
            x7 = x8;
            x8 = ' ';
        }
        if (x8 == ' ' && x9 != ' ')
        {
            x8 = x9;
            x9 = ' ';
        }
    }
    else if (shiftchoice == 7)
    {
        if (x7 == ' ' && x4 == ' ' && x1 != ' ')
        {
            x7 = x1;
            x1 = ' ';
        }
        if (x7 == ' ' && x4 != ' ')
        {
            x7 = x4;
            x4 = ' ';
        }
        if (x4 == ' ' && x1 != ' ')
        {
            x4 = x1;
            x1 = ' ';
        }
    }
    else if (shiftchoice == 8)
    {
        if (x8 == ' ' && x5 == ' ' && x2 != ' ')
        {
            x8 = x2;
            x2 = ' ';
        }
        if (x8 == ' ' && x5 != ' ')
        {
            x8 = x5;
            x5 = ' ';
        }
        if (x5 == ' ' && x2 != ' ')
        {
            x5 = x2;
            x2 = ' ';
        }
    }
    else if (shiftchoice == 9)
    {
        if (x9 == ' ' && x6 == ' ' && x3 != ' ')
        {
            x9 = x3;
            x3 = ' ';
        }
        if (x9 == ' ' && x6 != ' ')
        {
            x9 = x6;
            x6 = ' ';
        }
        if (x6 == ' ' && x3 != ' ')
        {
            x6 = x3;
            x3 = ' ';
        }
    }
    else if (shiftchoice == 10)
    {
        if (x1 == ' ' && x4 == ' ' && x7 != ' ')
        {
            x1 = x7;
            x7 = ' ';
        }
        if (x1 == ' ' && x4 != ' ')
        {
            x1 = x4;
            x4 = ' ';
        }
        if (x4 == ' ' && x7 != ' ')
        {
            x4 = x7;
            x7 = ' ';
        }
    }
    else if (shiftchoice == 11)
    {
        if (x2 == ' ' && x5 == ' ' && x8 != ' ')
        {
            x2 = x8;
            x8 = ' ';
        }
        if (x2 == ' ' && x5 != ' ')
        {
            x2 = x5;
            x5 = ' ';
        }
        if (x5 == ' ' && x8 != ' ')
        {
            x5 = x8;
            x8 = ' ';
        }
    }
    else if (shiftchoice == 12)
    {
        if (x3 == ' ' && x6 == ' ' && x9 != ' ')
        {
            x3 = x9;
            x9 = ' ';
        }
        if (x3 == ' ' && x6 != ' ')
        {
            x3 = x6;
            x6 = ' ';
        }
        if (x6 == ' ' && x9 != ' ')
        {
            x6 = x9;
            x9 = ' ';
        }
    }

    for (int i = 0; i < 17; i++)
    {
        Console.WriteLine();
    }

    Console.WriteLine("--- Target Board ---");
    Console.WriteLine();
    Console.WriteLine("   7  8  9  ");
    Console.WriteLine(" +---------+");
    Console.WriteLine($"1| {x11}  {x12}  {x13} |4");
    Console.WriteLine($" |         | ");
    Console.WriteLine($"2| {x14}  {x15}  {x16} |5");
    Console.WriteLine($" |         | ");
    Console.WriteLine($"3| {x17}  {x18}  {x19} |6");
    Console.WriteLine(" +---------+");
    Console.WriteLine("  10 11 12  ");
    Console.WriteLine($"--- Round {round} ---");

    Console.WriteLine();
    Console.WriteLine("   7  8  9  ");
    Console.WriteLine(" +---------+");
    Console.WriteLine($"1| {x1}  {x2}  {x3} |4");
    Console.WriteLine($" |         | ");
    Console.WriteLine($"2| {x4}  {x5}  {x6} |5");
    Console.WriteLine($" |         | ");
    Console.WriteLine($"3| {x7}  {x8}  {x9} |6" + ($"        Shift: {shiftchoicecounter} "));
    Console.WriteLine(" +---------+");
    Console.WriteLine("  10 11 12  ");
    round++;
    shiftchoicecounter++;

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}



