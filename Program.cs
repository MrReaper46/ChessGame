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
            Pawn PawnW1 = new Pawn(true, 1);
            PawnW1.SetPosition();
            Pawn PawnW2 = new Pawn(true, 2);
            PawnW2.SetPosition();
            Pawn PawnW3 = new Pawn(true, 3);
            PawnW3.SetPosition();
            Pawn PawnW4 = new Pawn(true, 4);
            PawnW4.SetPosition();
            Pawn PawnW5 = new Pawn(true, 5);
            PawnW5.SetPosition();
            Pawn PawnW6 = new Pawn(true, 6);
            PawnW6.SetPosition();
            Pawn PawnW7 = new Pawn(true, 7);
            PawnW7.SetPosition();
            Pawn PawnW8 = new Pawn(true, 8);
            PawnW8.SetPosition();
            Pawn PawnBl1 = new Pawn(false, 1);
            PawnBl1.SetPosition();
            Pawn PawnBl2 = new Pawn(false, 2);
            PawnBl2.SetPosition();
            Pawn PawnBl3 = new Pawn(false, 3);
            PawnBl3.SetPosition();
            Pawn PawnBl4 = new Pawn(false, 4);
            PawnBl4.SetPosition();
            Pawn PawnBl5 = new Pawn(false, 5);
            PawnBl5.SetPosition();
            Pawn PawnBl6 = new Pawn(false, 6);
            PawnBl6.SetPosition();
            Pawn PawnBl7 = new Pawn(false, 7);
            PawnBl7.SetPosition();
            Pawn PawnBl8 = new Pawn(false, 8);
            PawnBl8.SetPosition();
            Rook RookW1 = new Rook(true, 1);
            RookW1.SetPosition();
            Rook RookW2 = new Rook(true, 2);
            RookW2.SetPosition();
            Rook RookBl1 = new Rook(false, 1);
            RookBl1.SetPosition();
            Rook RookBl2 = new Rook(false, 2);
            RookBl2.SetPosition();
            Knight KnightW1 = new Knight(true, 1);
            KnightW1.SetPosition();
            Knight KnightW2 = new Knight(true, 2);
            KnightW2.SetPosition();
            Knight KnightBl1 = new Knight(false, 1);
            KnightBl1.SetPosition();
            Knight KnightBl2 = new Knight(false, 2);
            KnightBl2.SetPosition();
            Bishop BishopW1 = new Bishop(true, 1);
            BishopW1.SetPosition();
            Bishop BishopW2 = new Bishop(true, 2);
            BishopW2.SetPosition();
            Bishop BishopBl1 = new Bishop(false, 1);
            BishopBl1.SetPosition();
            Bishop BishopBl2 = new Bishop(false, 2);
            BishopBl2.SetPosition();
            Queen QueenW = new Queen(true);
            QueenW.SetPosition();
            Queen QueenBl = new Queen(false);
            QueenBl.SetPosition();
            King KingW = new King(true);
            KingW.SetPosition();
            King KingBl = new King(false);
            KingBl.SetPosition();
            Console.WriteLine($"King Black X is: {KingBl.X}");
            Console.WriteLine($"King Black Y is: {KingBl.Y}");
        }
    }
}
