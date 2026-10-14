Random rnd = new Random();
Random rnd2 = new Random();
string playerChoice = "";
int playerChoiceNumber = 0;
string PlayerName = " ";
int boardScore = 0;
// menülerde kullanıcılardan girdiler aldık ve bunların hatalarını düşünerek oyunun kapanmaması için hata denetlemesi yaptık
do
{
    Console.Write("1-Human 2-Computer: ");
    playerChoice = Console.ReadLine();
    if (!int.TryParse(playerChoice, out playerChoiceNumber) || string.IsNullOrEmpty(playerChoice))
    {
        Console.WriteLine("Please enter a valid number");

    }
    else if (playerChoiceNumber > 2 || playerChoiceNumber < 0)
    {
        Console.WriteLine("Please enter a number between 1-2");
    }
} while ((!int.TryParse(playerChoice, out playerChoiceNumber) || string.IsNullOrEmpty(playerChoice)) || (playerChoiceNumber > 2 || playerChoiceNumber < 0));
string player = "";
switch (playerChoiceNumber)
{
    case 1:
        player = " Human";
        do
        {
            Console.Write("Enter your name: ");
            PlayerName = Console.ReadLine();
            if (string.IsNullOrEmpty(PlayerName))
            {
                Console.WriteLine("Invalide name please enter your name again: ");
            }                
        } while (string.IsNullOrEmpty(PlayerName));
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

string CharType = "";
int CharTypeChoiceNumber = 0;

do
{
    Console.Write("Enter number of types of symbols between 1 - 5: ");
    CharType = Console.ReadLine();
    if (!int.TryParse(CharType, out CharTypeChoiceNumber) || string.IsNullOrEmpty(CharType))
    {
        Console.WriteLine("Please enter a valid option");
    }
    else if (CharTypeChoiceNumber > 5 || CharTypeChoiceNumber < 1)
    {
        Console.WriteLine("Please enter a number between 1-5");
    }
} while ((CharTypeChoiceNumber > 5 || CharTypeChoiceNumber < 1));

string typeOfSymbols = "";

switch (CharTypeChoiceNumber)
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

string SymbolNumberCoice = "";
int SymbolNumber = 0;
do
{
    Console.Write("Enter number of symbols between 1 - 6: ");
    SymbolNumberCoice = Console.ReadLine();
    if (!int.TryParse(SymbolNumberCoice, out SymbolNumber) || string.IsNullOrEmpty(SymbolNumberCoice))
    {
        Console.WriteLine("Enter a valid number");
    }
    else if (SymbolNumber > 6 || SymbolNumber < 1)
    {
        Console.WriteLine("Please Enter a number between 1-6");
    }
    else if (SymbolNumber < CharTypeChoiceNumber)
    {
        Console.WriteLine("Number of symbols can not be less than number of types of symbols.");
    }

} while ((!int.TryParse(SymbolNumberCoice, out SymbolNumber) || string.IsNullOrEmpty(SymbolNumberCoice)) || (SymbolNumber > 6 || SymbolNumber < 1) || (SymbolNumber < CharTypeChoiceNumber));

string ShiftChoice = "";
int ShiftChoiceNumber = 0;

do
{
    Console.Write("Enter a shift number between 1-20: ");
    ShiftChoice = Console.ReadLine();
    if (!int.TryParse(ShiftChoice, out ShiftChoiceNumber) || string.IsNullOrEmpty(ShiftChoice))
    {
        Console.WriteLine("Enter a valid nmber");
    }
    else if (ShiftChoiceNumber > 20 || ShiftChoiceNumber < 1)
    {
        Console.WriteLine("Please Enter a number between 1-20");
    }
} while ((!int.TryParse(ShiftChoice, out ShiftChoiceNumber) || string.IsNullOrEmpty(ShiftChoice)) || (ShiftChoiceNumber > 20 || ShiftChoiceNumber < 1));



Console.WriteLine("Game Mode");
Console.WriteLine("-------------");
Console.WriteLine($"Player: {player}");
if (playerChoiceNumber == 1)
    Console.WriteLine($"Player name is: {PlayerName}");
Console.WriteLine($"Symbols: {typeOfSymbols}");
Console.WriteLine($"Number of symbols: {SymbolNumber}");
Console.WriteLine($"Number of shifts :{ShiftChoiceNumber}");

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
//atadığımız kordinatların tekrar etmesini önlemek için kaydedip kontrol ediyoruz
int x = 0;
int a = 0;
int b = 0;
int c = 0;
int d = 0;
int e = 0;
int f = 0;

int round = 1;
//atadığımız kordinatlara atanmasını istediğimiz harfler istedik, kordinatların birbiri ile çakışmaması için denetleme yaptık
if (SymbolNumber == 1)
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
else if (SymbolNumber == 2)
{
    if (CharTypeChoiceNumber == 1)
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
    else if (CharTypeChoiceNumber == 2)
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

else if (SymbolNumber == 3)
{
    if (CharTypeChoiceNumber == 1)
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
    else if (CharTypeChoiceNumber == 2)
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
    else if (CharTypeChoiceNumber == 3)
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
else if (SymbolNumber == 4)
{
    if (CharTypeChoiceNumber == 1)
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
    else if (CharTypeChoiceNumber == 2)
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
    else if (CharTypeChoiceNumber == 3)
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
    else if (CharTypeChoiceNumber == 4)
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
else if (SymbolNumber == 5)
{
    if (CharTypeChoiceNumber == 1)
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
    else if (CharTypeChoiceNumber == 2)
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
    else if (CharTypeChoiceNumber == 3)
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
    else if (CharTypeChoiceNumber == 4)
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
    else if (CharTypeChoiceNumber == 5)
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
else if (SymbolNumber == 6)
{
    if (CharTypeChoiceNumber == 1)
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
    else if (CharTypeChoiceNumber == 2)
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
    else if (CharTypeChoiceNumber == 3)
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
    else if (CharTypeChoiceNumber == 4)
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
    else if (CharTypeChoiceNumber == 5)
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
//Bilgisayarın bulucağı kordinat ile oyuncunun boardındaki kordinatları eşleştiriyoruz
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
// bilgisayarın kaydırma işlemini gerçekeştirebilmesi için bilgisayara ayrı bir değer atayarak oluşturmasını sağladık
for (int i = 1; i <= ShiftChoiceNumber; i++)
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
// burada bilgisayarın target board ile oyuncunun boardını ayrı bir yerde oyuncu kaydırma işlemini yaptığında target board değişmesin diye depoladık
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
// oyuncunun kaydırma işlemini yapması için boş ya da dolu olup olmadığını kontrol etmeye çalıştık
while (start)
{
    Console.Write("Type a number: ");
    int PlayerShiftChoiceNumber = Convert.ToInt32(Console.ReadLine());

    if (PlayerShiftChoiceNumber == 1)
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
    else if (PlayerShiftChoiceNumber == 2)
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
    else if (PlayerShiftChoiceNumber == 3)
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
    else if (PlayerShiftChoiceNumber == 4)
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
    else if (PlayerShiftChoiceNumber == 5)
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
    else if (PlayerShiftChoiceNumber == 6)
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
    else if (PlayerShiftChoiceNumber == 7)
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
    else if (PlayerShiftChoiceNumber == 8)
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
    else if (PlayerShiftChoiceNumber == 9)
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
    else if (PlayerShiftChoiceNumber == 10)
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
    else if (PlayerShiftChoiceNumber == 11)
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
    else if (PlayerShiftChoiceNumber == 12)
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
    //oyuncunun boardı ile target boardın eşit olup olmadığını karşılaştırıp puanı hesapladık
    boardScore = 0;

    if (x1 == x11)
    {
        if (x1 == firstChar)
        {
            boardScore += 1;
        }
        else if (x1 == secondChar)
        {
            boardScore += 2;
        }
        else if (x1 == thirdChar)
        {
            boardScore += 3;
        }
        else if (x1 == fourthChar)
        {
            boardScore += 4;
        }
        else if (x1 == fifthChar)
        {
            boardScore += 5;
        }
    }
    if (x3 == x13)
    {
        if (x3 == firstChar)
        {
            boardScore += 1;
        }
        else if (x3 == secondChar)
        {
            boardScore += 2;
        }
        else if (x3 == thirdChar)
        {
            boardScore += 3;
        }
        else if (x3 == fourthChar)
        {
            boardScore += 4;
        }
        else if (x3 == fifthChar)
        {
            boardScore += 5;
        }
    }
    if (x5 == x15)
    {
        if (x5 == firstChar)
        {
            boardScore += 1;
        }
        else if (x5 == secondChar)
        {
            boardScore += 2;
        }
        else if (x5 == thirdChar)
        {
            boardScore += 3;
        }
        else if (x5 == fourthChar)
        {
            boardScore += 4;
        }
        else if (x5 == fifthChar)
        {
            boardScore += 5;
        }
    }
    if (x7 == x17)
    {
        if (x7 == firstChar)
        {
            boardScore += 1;
        }
        else if (x7 == secondChar)
        {
            boardScore += 2;
        }
        else if (x7 == thirdChar)
        {
            boardScore += 3;
        }
        else if (x7 == fourthChar)
        {
            boardScore += 4;
        }
        else if (x7 == fifthChar)
        {
            boardScore += 5;
        }
    }

    if (x2 == x12)
    {
        if (x2 == firstChar)
        {
            boardScore += 2;
        }
        else if (x2 == secondChar)
        {
            boardScore += 4;
        }
        else if (x2 == thirdChar)
        {
            boardScore += 6;
        }
        else if (x2 == fourthChar)
        {
            boardScore += 8;
        }
        else if (x2 == fifthChar)
        {
            boardScore += 10;
        }
    }
    if (x4 == x14)
    {
        if (x4 == firstChar)
        {
            boardScore += 2;
        }
        else if (x4 == secondChar)
        {
            boardScore += 4;
        }
        else if (x4 == thirdChar)
        {
            boardScore += 6;
        }
        else if (x4 == fourthChar)
        {
            boardScore += 8;
        }
        else if (x4 == fifthChar)
        {
            boardScore += 10;
        }
    }
    if (x6 == x16)
    {
        if (x6 == firstChar)
        {
            boardScore += 2;
        }
        else if (x6 == secondChar)
        {
            boardScore += 4;
        }
        else if (x6 == thirdChar)
        {
            boardScore += 6;
        }
        else if (x6 == fourthChar)
        {
            boardScore += 8;
        }
        else if (x6 == fifthChar)
        {
            boardScore += 10;
        }
    }
    if (x8 == x18)
    {
        if (x8 == firstChar)
        {
            boardScore += 2;
        }
        else if (x8 == secondChar)
        {
            boardScore += 4;
        }
        else if (x8 == thirdChar)
        {
            boardScore += 6;
        }
        else if (x8 == fourthChar)
        {
            boardScore += 8;
        }
        else if (x8 == fifthChar)
        {
            boardScore += 10;
        }
    }
    if (x5 == x15)
    {
        if (x5 == firstChar)
        {
            boardScore += 4;
        }
        else if (x5 == secondChar)
        {
            boardScore += 8;
        }
        else if (x5 == thirdChar)
        {
            boardScore += 12;
        }
        else if (x5 == fourthChar)
        {
            boardScore += 16;
        }
        else if (x5 == fifthChar)
        {
            boardScore += 20;
        }
    }

    for (int i = 0; i < 17; i++)
    {
        Console.WriteLine();
    }
    //oyuncuya aynı anda hem target hemde player boardı göstererek oyuncuya rahatlık sağladık
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
    Console.WriteLine($"1| {x1}  {x2}  {x3} |4" + ($"        Board Score: {boardScore} "));
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
    //oyuncu target boardı oluşturduğunda oyun scorunu hesaplayıp kapanmasını sağladık
    if (x1 == x11 && x2 == x12 && x3 == x13 && x4 == x14 && x5 == x15 && x6 == x16 && x7 == x17 && x8 == x18 && x9 == x19)
    {
        int gameScore = (10 * boardScore) + ((CharTypeChoiceNumber * SymbolNumber) * (ShiftChoiceNumber - shiftchoicecounter));

        Console.WriteLine($"Game score: {gameScore}");
        break;
    }
}
//playerChoice: oyuncu oynayacak oyuncuyu seçiyor
//playerChoiceNumber: oyuncunun seçtiği oyuncuyu sayı olarak depoluyoruz
//PlayerName: Oyuncunu ismini alıyoruz ve depoluyoruz
//CharType: Oyuncunun hangi harfleri kullanacağını alıyoruz
//CharTypeChoiceNumber:Oyuncunun hangi harfleri kullanacağını sayı olarak depoluyoruz
//SymbolNumberCoice:Oyuncunun kaç tane sembol kullanacağını alıyoruz
//SymbolNumber:Oyuncunun kaç tane sembol kullanacağını sayı olarak depoluyoruz
//ShiftChoice:Oyuncudan kaç kez kaydırmasını istediğini alıyoruz
//ShiftChoiceNumber:Oyuncudan kaç kez kaydırmasını istediğini sayı olarak depoluyoruz