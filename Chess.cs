using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Chess
    {
        public string Name;
        public int X, Y, Order;
        public bool isWhite;
        public Chess(string Name, bool isWhite, int X, int Y, int Order)
        {
            this.Name = Name;
            this.X = X;
            this.Y = Y;
            this.isWhite = isWhite;
            this.Order = Order;
        }
    }
    public class Pawn : Chess
    {
        public Pawn(bool isWhite, int Order) : base("Pawn", isWhite, 0, 0,Order)
        {
            this.isWhite = isWhite;
            this.Order = Order;
        }
        public void SetPosition()
        {
            string Color="White";
            X = Order - 1;
            switch (isWhite)
            {
                case true:
                    Color = "White";
                    break;
                case false:
                    Color = "Black";
                    break;
            }
            if (isWhite)
            {
                Y = 1;
            }
            else
            {
                Y = 6;
            }
            Console.WriteLine($"{this.Name} {Color} {this.Order}'s Location is: [{this.X},{this.Y}]");
        }
    }
    public class Rook : Chess
    {
        public Rook(bool isWhite, int Order) : base("Rook", isWhite, 0, 0,Order)
        {
            this.isWhite = isWhite;
            this.Order = Order;
        }
        public void SetPosition()
        {
            string Color = "White";
            switch (isWhite)
            {
                case true:
                    Color = "White";
                    break;
                case false:
                    Color = "Black";
                    break;
            }
            switch (Order)
            {
                case 1:
                    X = 0;
                    break;
                case 2:
                    X = 7;
                    break;
            }
            if (isWhite)
            {
                Y = 0;
            }
            else
            {
                Y = 7;
            }
            Console.WriteLine($"{this.Name} {Color} {this.Order}'s Location is: [{this.X},{this.Y}]");
        }
    }
    public class Bishop : Chess
    {
        public Bishop(bool isWhite, int Order) : base("Bishop", isWhite, 0, 0,Order)
        {
            this.isWhite = isWhite;
            this.Order = Order;
        }
        public void SetPosition()
        {
            string Color = "White";
            switch (isWhite)
            {
                case true:
                    Color = "White";
                    break;
                case false:
                    Color = "Black";
                    break;
            }
            switch (Order)
            {
                case 1:
                    X = 2;
                    break;
                case 2:
                    X = 5;
                    break;
            }
            if (isWhite)
            {
                Y = 0;
            }
            else
            {
                Y = 7;
            }
            Console.WriteLine($"{this.Name} {Color} {this.Order}'s Location is: [{this.X},{this.Y}]");
        }
    }
    public class Knight : Chess
    {
        public Knight(bool isWhite, int Order) : base("Knight", isWhite, 0, 0, Order)
        {
            this.isWhite = isWhite;
            this.Order = Order;
        }
        public void SetPosition()
        {
            string Color = "White";
            switch (isWhite)
            {
                case true:
                    Color = "White";
                    break;
                case false:
                    Color = "Black";
                    break;
            }
            switch (Order)
            {
                case 1:
                    X = 1;
                    break;
                case 2:
                    X = 6;
                    break;
            }
            if (isWhite)
            {
                Y = 0;
            }
            else
            {
                Y = 7;
            }
            Console.WriteLine($"{this.Name} {Color} {this.Order}'s Location is: [{this.X},{this.Y}]");
        }
    }
    public class Queen : Chess
    {
        public Queen(bool isWhite) : base("Queen", isWhite, 0, 0, 0)
        {
            this.isWhite = isWhite;
        }
        public void SetPosition()
        {
            string Color = "White";
            switch (isWhite)
            {
                case true:
                    Color = "White";
                    break;
                case false:
                    Color = "Black";
                    break;
            }
            X = 3;
            if (isWhite)
            {
                Y = 0;
            }
            else
            {
                Y = 7;
            }
            Console.WriteLine($"{this.Name} {Color} 's Location is: [{this.X},{this.Y}]");
        }
    }
    public class King : Chess
    {
        public King(bool isWhite) : base("King", isWhite, 0, 0, 0)
        {
            this.isWhite = isWhite;
        }
        public void SetPosition()
        {
            string Color = "White";
            switch (isWhite)
            {
                case true:
                    Color = "White";
                    break;
                case false:
                    Color = "Black";
                    break;
            }
            X = 4;
            if (isWhite)
            {
                Y = 0;
            }
            else
            {
                Y = 7;
            }
            Console.WriteLine($"{this.Name} {Color} 's Location is: [{this.X},{this.Y}]");
        }
    }
}
