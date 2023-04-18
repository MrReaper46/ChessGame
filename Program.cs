using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object Indetifier
            Pawn PawnW1 = new Pawn(true, 1);
            PawnW1.GetPosition();
            Pawn PawnW2 = new Pawn(true, 2);
            PawnW2.GetPosition();
            Pawn PawnW3 = new Pawn(true, 3);
            PawnW3.GetPosition();
            Pawn PawnW4 = new Pawn(true, 4);
            PawnW4.GetPosition();
            Pawn PawnW5 = new Pawn(true, 5);
            PawnW5.GetPosition();
            Pawn PawnW6 = new Pawn(true, 6);
            PawnW6.GetPosition();
            Pawn PawnW7 = new Pawn(true, 7);
            PawnW7.GetPosition();
            Pawn PawnW8 = new Pawn(true, 8);
            PawnW8.GetPosition();
            Pawn PawnBl1 = new Pawn(false, 1);
            PawnBl1.GetPosition();
            Pawn PawnBl2 = new Pawn(false, 2);
            PawnBl2.GetPosition();
            Pawn PawnBl3 = new Pawn(false, 3);
            PawnBl3.GetPosition();
            Pawn PawnBl4 = new Pawn(false, 4);
            PawnBl4.GetPosition();
            Pawn PawnBl5 = new Pawn(false, 5);
            PawnBl5.GetPosition();
            Pawn PawnBl6 = new Pawn(false, 6);
            PawnBl6.GetPosition();
            Pawn PawnBl7 = new Pawn(false, 7);
            PawnBl7.GetPosition();
            Pawn PawnBl8 = new Pawn(false, 8);
            PawnBl8.GetPosition();
            Rook RookW1 = new Rook(true, 1);
            RookW1.GetPosition();
            Rook RookW2 = new Rook(true, 2);
            RookW2.GetPosition();
            Rook RookBl1 = new Rook(false, 1);
            RookBl1.GetPosition();
            Rook RookBl2 = new Rook(false, 2);
            RookBl2.GetPosition();
            Knight KnightW1 = new Knight(true, 1);
            KnightW1.GetPosition();
            Knight KnightW2 = new Knight(true, 2);
            KnightW2.GetPosition();
            Knight KnightBl1 = new Knight(false, 1);
            KnightBl1.GetPosition();
            Knight KnightBl2 = new Knight(false, 2);
            KnightBl2.GetPosition();
            Bishop BishopW1 = new Bishop(true, 1);
            BishopW1.GetPosition();
            Bishop BishopW2 = new Bishop(true, 2);
            BishopW2.GetPosition();
            Bishop BishopBl1 = new Bishop(false, 1);
            BishopBl1.GetPosition();
            Bishop BishopBl2 = new Bishop(false, 2);
            BishopBl2.GetPosition();
            Queen QueenW = new Queen(true);
            QueenW.GetPosition();
            Queen QueenBl = new Queen(false);
            QueenBl.GetPosition();
            King KingW = new King(true);
            KingW.GetPosition();
            King KingBl = new King(false);
            KingBl.GetPosition();
            #endregion

            #region Testing SetLocation()
            /*
            Console.WriteLine($"- Pawn White 1 X is: {PawnW1.X}");
            Console.WriteLine($"- Pawn White 1 Y is: {PawnW1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn White 2 X is: {PawnW2.X}");
            Console.WriteLine($"- Pawn White 2 Y is: {PawnW2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn White 3 X is: {PawnW3.X}");
            Console.WriteLine($"- Pawn White 3 Y is: {PawnW3.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn White 4 X is: {PawnW4.X}");
            Console.WriteLine($"- Pawn White 4 Y is: {PawnW4.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn White 5 X is: {PawnW5.X}");
            Console.WriteLine($"- Pawn White 5 Y is: {PawnW5.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn White 6 X is: {PawnW6.X}");
            Console.WriteLine($"- Pawn White 6 Y is: {PawnW6.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn White 7 X is: {PawnW7.X}");
            Console.WriteLine($"- Pawn White 7 Y is: {PawnW7.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn White 8 X is: {PawnW8.X}");
            Console.WriteLine($"- Pawn White 8 Y is: {PawnW8.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 1 X is: {PawnBl1.X}");
            Console.WriteLine($"- Pawn Black 1 Y is: {PawnBl1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 2 X is: {PawnBl2.X}");
            Console.WriteLine($"- Pawn Black 2 Y is: {PawnBl2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 3 X is: {PawnBl3.X}");
            Console.WriteLine($"- Pawn Black 3 Y is: {PawnBl3.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 4 X is: {PawnBl4.X}");
            Console.WriteLine($"- Pawn Black 4 Y is: {PawnBl4.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 5 X is: {PawnBl5.X}");
            Console.WriteLine($"- Pawn Black 5 Y is: {PawnBl5.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 6 X is: {PawnBl6.X}");
            Console.WriteLine($"- Pawn Black 6 Y is: {PawnBl6.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 7 X is: {PawnBl7.X}");
            Console.WriteLine($"- Pawn Black 7 Y is: {PawnBl7.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Pawn Black 8 X is: {PawnBl8.X}");
            Console.WriteLine($"- Pawn Black 8 Y is: {PawnBl8.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Rook White Left X is: {RookW1.X}");
            Console.WriteLine($"- Rook White Left Y is: {RookW1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Rook White Right X is: {RookW2.X}");
            Console.WriteLine($"- Rook White Right Y is: {RookW2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Rook Black Left X is: {RookBl1.X}");
            Console.WriteLine($"- Rook Black Left Y is: {RookBl1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Rook Black Right X is: {RookBl2.X}");
            Console.WriteLine($"- Rook Black Right Y is: {RookBl2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Knight White Left X is: {KnightW1.X}");
            Console.WriteLine($"- Knight White Left Y is: {KnightW1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Knight White Right X is: {KnightW2.X}");
            Console.WriteLine($"- Knight White Right Y is: {KnightW2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Knight Black Left X is: {KnightBl1.X}");
            Console.WriteLine($"- Knight Black Left Y is: {KnightBl1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Knight Black Right X is: {KnightBl2.X}");
            Console.WriteLine($"- Knight Black Right Y is: {KnightBl2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Bishop White Left X is: {BishopW1.X}");
            Console.WriteLine($"- Bishop White Left Y is: {BishopW1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Bishop White Right X is: {BishopW2.X}");
            Console.WriteLine($"- Bishop White Right Y is: {BishopW2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Bishop Black Left X is: {BishopBl1.X}");
            Console.WriteLine($"- Bishop Black Left Y is: {BishopBl1.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Bishop Black Right X is: {BishopBl2.X}");
            Console.WriteLine($"- Bishop Black Right Y is: {BishopBl2.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Queen White X is: {QueenW.X}");
            Console.WriteLine($"- Queen White Y is: {QueenW.Y}");
            Console.WriteLine();
            Console.WriteLine($"- Queen Black X is: {QueenBl.X}");
            Console.WriteLine($"- Queen Black Y is: {QueenBl.Y}");
            Console.WriteLine();
            Console.WriteLine($"- King White X is: {KingW.X}");
            Console.WriteLine($"- King White Y is: {KingW.Y}");
            Console.WriteLine();
            Console.WriteLine($"- King Black X is: {KingBl.X}");
            Console.WriteLine($"- King Black Y is: {KingBl.Y}");
            Console.WriteLine();
            */
            #endregion

            #region Set Object Location
            string[,] ChessBoard = new string[8, 8];
            ChessBoard[PawnW1.Y, PawnW1.X] = PawnW1.Legend;
            ChessBoard[PawnW2.Y, PawnW2.X] = PawnW2.Legend;
            ChessBoard[PawnW3.Y, PawnW3.X] = PawnW3.Legend;
            ChessBoard[PawnW4.Y, PawnW4.X] = PawnW4.Legend;
            ChessBoard[PawnW5.Y, PawnW5.X] = PawnW5.Legend;
            ChessBoard[PawnW6.Y, PawnW6.X] = PawnW6.Legend;
            ChessBoard[PawnW7.Y, PawnW7.X] = PawnW7.Legend;
            ChessBoard[PawnW8.Y, PawnW8.X] = PawnW8.Legend;
            ChessBoard[RookW1.Y, RookW1.X] = RookW1.Legend;
            ChessBoard[RookW2.Y, RookW2.X] = RookW2.Legend;
            ChessBoard[KnightW1.Y, KnightW1.X] = KnightW1.Legend;
            ChessBoard[KnightW2.Y, KnightW2.X] = KnightW2.Legend;
            ChessBoard[BishopW1.Y, BishopW1.X] = BishopW1.Legend;
            ChessBoard[BishopW2.Y, BishopW2.X] = BishopW2.Legend;
            ChessBoard[QueenW.Y, QueenW.X] = QueenW.Legend;
            ChessBoard[KingW.Y, KingW.X] = KingW.Legend;

            ChessBoard[PawnBl1.Y, PawnBl1.X] = PawnBl1.Legend;
            ChessBoard[PawnBl2.Y, PawnBl2.X] = PawnBl2.Legend;
            ChessBoard[PawnBl3.Y, PawnBl3.X] = PawnBl3.Legend;
            ChessBoard[PawnBl4.Y, PawnBl4.X] = PawnBl4.Legend;
            ChessBoard[PawnBl5.Y, PawnBl5.X] = PawnBl5.Legend;
            ChessBoard[PawnBl6.Y, PawnBl6.X] = PawnBl6.Legend;
            ChessBoard[PawnBl7.Y, PawnBl7.X] = PawnBl7.Legend;
            ChessBoard[PawnBl8.Y, PawnBl8.X] = PawnBl8.Legend;
            ChessBoard[RookBl1.Y, RookBl1.X] = RookBl1.Legend;
            ChessBoard[RookBl2.Y, RookBl2.X] = RookBl2.Legend;
            ChessBoard[KnightBl1.Y, KnightBl1.X] = KnightBl1.Legend;
            ChessBoard[KnightBl2.Y, KnightBl2.X] = KnightBl2.Legend;
            ChessBoard[BishopBl1.Y, BishopBl1.X] = BishopBl1.Legend;
            ChessBoard[BishopBl2.Y, BishopBl2.X] = BishopBl2.Legend;
            ChessBoard[QueenBl.Y, QueenBl.X] = QueenBl.Legend;
            ChessBoard[KingBl.Y, KingBl.X] = KingBl.Legend;
            #endregion

            #region Show Result

            for (int i = 0; i < ChessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ChessBoard.GetLength(1); j++)
                {
                    if (ChessBoard[i, j] == null)
                    {
                        ChessBoard[i, j] = "-  ";
                        Console.Write(ChessBoard[i, j]);
                    }
                    else
                    {
                        Console.Write(ChessBoard[i, j]);
                    }
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
