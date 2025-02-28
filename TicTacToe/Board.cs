class Board 
{
    private Figures[] board = new Figures[9];
    public bool UpdateBoard(int square, Figures figure) 
    {
        if (board[square] == Figures.Empty) 
        {
            board[square] = figure;
            return true;
        }

        return false;
    }
    public void DisplayBoard() 
    {
        for (int i = 0;i < 3;i++) 
        {
            for (int j = 0;j < 3;j++) 
            {
                string figureString = board[(i*3)+j] switch {
                    Figures.Empty => " ",
                    Figures.Cross => "x",
                    Figures.Circle => "o",
                    _ => " "
                };

                Console.Write($" {figureString} ");
            }
            Console.WriteLine();

        }

        Console.WriteLine();
    }

    private bool IsFull() 
    {
        if (board.Contains(Figures.Empty)) return false;

        return true;
    }

    private bool CheckDiagonals(Figures figure) 
    {
        if (board[0] == figure && board[4] == figure && board[8] == figure) return true;

        if (board[2] == figure && board[4] == figure && board[6] == figure) return true;

        return false;
    }

    private bool CheckLines(Figures figure) 
    {
        for (int i = 0;i < 3;i++) 
        {
            if (board[i] == figure && board[i + 1] == figure && board[i + 2] == figure) return true;

            if (board[i] == figure && board[i + 3] == figure && board[i + 6] == figure) return true;
        }

        return false;
    }


    public Results GetWinner(Player player, Player player2) 
    {
        if (CheckDiagonals(player.Figure) || CheckLines(player.Figure)) 
        {
            return Results.Win;
        } else if (IsFull()) 
        {
            return Results.Draw;
        } else if (CheckDiagonals(player2.Figure) || CheckLines(player2.Figure)) 
        {
            return Results.Lose;
        }else {
            return Results.Playing;
        }
    }
}

