class Turn {
    public void PlayTurn(Player player, Board board) {
        while (true) {
            int square = player.GetSquare();

            if (board.UpdateBoard(square - 1,player.Figure)) {
                break;
            } else {
                Console.WriteLine("This square is not empty! Try again.");
                continue;
            }
        }

        board.DisplayBoard();
    }
}

