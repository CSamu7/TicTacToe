Board board = new Board();
Turn turn = new Turn();
Results result = Results.Playing;

Console.WriteLine("Tic Tac Toe");
Console.WriteLine("Choose your figure (x,o) Player 1. If you don't choose, by default will be cross.");
string input = Console.ReadLine();

Figures figure = input switch 
{
    "x" => Figures.Cross,
    "o" => Figures.Circle,
    _ => Figures.Cross
};

Player player1 = new Player("Player 1", figure);

Figures figure2 = figure == Figures.Cross ? Figures.Circle : Figures.Cross;
Console.WriteLine($"Player 2, your figure is {figure2}");
Player player2 = new Player("Player 2", figure2);

while (true) 
{
    turn.PlayTurn(player1, board);
    result = board.GetWinner(player1,player2);
    if(result != Results.Playing) break;

    turn.PlayTurn(player2, board);
    result = board.GetWinner(player1, player2);
    if (result != Results.Playing) break;
}

if (result == Results.Win)
{
    Console.WriteLine("You have won Player 1!");
} else if (result == Results.Draw) 
{
    Console.WriteLine("Draw");
} else if (result == Results.Lose)
{
    Console.WriteLine("You have won Player 2!");
}

enum Figures { Empty, Cross, Circle };
enum Results { Win, Draw, Lose, Playing};