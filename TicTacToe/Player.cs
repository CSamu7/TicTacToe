class Player 
{
    public string Name { get; init; }
    public Figures Figure { get; init; }
    public Player(string name, Figures figure) 
    { 
        Name = name;
        Figure = figure;    
    } 

    public int GetSquare() 
    {
        Console.WriteLine($"Its your turn {Name}");
        Console.Write("Choose a square (1-9): ");

        while (true) 
        {
            int square = Convert.ToInt32(Console.ReadLine());

            if (square < 1 || square > 9) 
            {
                Console.Write("The square must be between 1-9. Try again: ");
                continue;
            } else 
            {
                return square;
            }
        }
    }
}

