char cell1 = '1', cell2 = '2', cell3 = '3',
     cell4 = '4', cell5 = '5', cell6 = '6',
     cell7 = '7', cell8 = '8', cell9 = '9';

int player = 1;
int gameStatus = 0;

Console.WriteLine("Гравець 1: X і Гравець 2: O");
Console.WriteLine("Виберіть номер клітинки для розміщення вашого знаку.");

// Головний цикл гри
do
{
    char symbol = player == 1 ? 'X' : 'O';
    bool continueGame = true;

    do
    {
        Console.Clear();
        Console.WriteLine($" {cell1}  | {cell2}  | {cell3} ");
        Console.WriteLine("----|-----|----");
        Console.WriteLine($" {cell4}  | {cell5}  | {cell6} ");
        Console.WriteLine("----|-----|----");
        Console.WriteLine($" {cell7}  | {cell8}  | {cell9} ");

        Console.WriteLine($"Гравець {player}, виберіть клітинку (1-9): ");

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 9)
        {
            switch (choice)
            {
                case 1 when cell1 == '1': cell1 = symbol; continueGame = false; break;
                case 2 when cell2 == '2': cell2 = symbol; continueGame = false; break;
                case 3 when cell3 == '3': cell3 = symbol; continueGame = false; break;
                case 4 when cell4 == '4': cell4 = symbol; continueGame = false; break;
                case 5 when cell5 == '5': cell5 = symbol; continueGame = false; break;
                case 6 when cell6 == '6': cell6 = symbol; continueGame = false; break;
                case 7 when cell7 == '7': cell7 = symbol; continueGame = false; break;
                case 8 when cell8 == '8': cell8 = symbol; continueGame = false; break;
                case 9 when cell9 == '9': cell9 = symbol; continueGame = false; break;
                
                
                default:
                    Console.WriteLine("Клітинка вже зайнята!");
                    Console.ReadKey();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Неправильний вибір! Введіть число від 1 до 9.");
            Console.ReadKey();
        }
    } while (continueGame);

    // Перевірка переможця
    if (cell1 == cell2 && cell2 == cell3 ||
        cell4 == cell5 && cell5 == cell6 ||
        cell7 == cell8 && cell8 == cell9 ||
        cell1 == cell4 && cell4 == cell7 ||
        cell2 == cell5 && cell5 == cell8 ||
        cell3 == cell6 && cell6 == cell9 ||
        cell1 == cell5 && cell5 == cell9 ||
        cell3 == cell5 && cell5 == cell7)
    {
        gameStatus = 1;
    }
    // Перевірка нічиї
    else if (cell1 != '1' && cell2 != '2' && cell3 != '3' &&
             cell4 != '4' && cell5 != '5' && cell6 != '6' &&
             cell7 != '7' && cell8 != '8' && cell9 != '9')
    {
        gameStatus = -1;
    }
    else
    {
        player = player == 1 ? 2 : 1; // Зміна гравця
    }

} while (gameStatus == 0);

// Фінальний вивід
Console.Clear();
Console.WriteLine($" {cell1}  | {cell2}  | {cell3} ");
Console.WriteLine("----|-----|----");
Console.WriteLine($" {cell4}  | {cell5}  | {cell6} ");
Console.WriteLine("----|-----|----");
Console.WriteLine($" {cell7}  | {cell8}  | {cell9} ");

if (gameStatus == 1)
{
    Console.WriteLine($"Гравець {player} виграв!");
}
else
{
    Console.WriteLine("Нічия!");
}





