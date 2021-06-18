using RoboticSpider.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboticSpider.Model
{
    public class Spider
    {
        public int MaxX { get; private set;}
        public int MaxY { get; private set; }
        public int CurrX { get; private set; }
        public int CurrY { get; private set; }
        public SpiderDirection Direction { get; set; }


        public Spider(int maxX, int maxY, int currX, int currY, SpiderDirection direction)
        {
            SetMaxX(maxX);
            SetMaxY(maxY);
            SetCurrX(currX);
            SetCurrY(currY);
            SetDirection(direction);


        }
        public void SetMaxX (int value)
        {
            if (value < 0)
                throw new Exception("MaxX cannot be negative.");

            MaxX = value;
        }

        public void SetMaxY (int value)
        {
            if (value < 0)
                throw new Exception("MaxY cannot be negative.");

            MaxY = value;
        }

        public void SetCurrX(int value)
        {
            if (value < 0)
                throw new Exception("X cannot be negative.");

            if (value > MaxX)
                throw new Exception("X cannot be greater than MaxX.");

            CurrX = value;
        }

        public void SetCurrY(int value)
        {
            if (value < 0)
                throw new Exception("Y cannot be negative.");

            if (value > MaxY)
                throw new Exception("Y cannot be greater than MaxY.");

            CurrY = value;
        }

        public void SetDirection(SpiderDirection value)
        {
            Direction = value;
        }

        public void SetMove(SpiderMove[] moves)
        {
            for (var i=0; i<moves.Length;i++)
                switch (moves[i])
                {
                    case SpiderMove.F:
                        switch (Direction)
                        {
                            case SpiderDirection.Left:
                                if (CurrX - 1 > 0)
                                    CurrX -= 1;
                                break;
                            case SpiderDirection.Right:
                                if (CurrY + 1 > MaxX)
                                    CurrX += 1;
                                break;
                            case SpiderDirection.Up:
                                if (CurrY + 1 > MaxY)
                                    CurrY += 1;
                                break;
                            case SpiderDirection.Down:
                                if (CurrY - 1 > 0)
                                    CurrY -= 1;
                                break;

                        }
                        break;
                    case SpiderMove.L:
                        switch (Direction)
                        {
                            case SpiderDirection.Left:
                                Direction = SpiderDirection.Down;
                                break;
                            case SpiderDirection.Right:
                                Direction = SpiderDirection.Up;
                                break;
                            case SpiderDirection.Up:
                                Direction = SpiderDirection.Left;
                                break;
                            case SpiderDirection.Down:
                                Direction = SpiderDirection.Right;
                                break;

                        }
                        break;
                    case SpiderMove.R:
                        switch (Direction)
                        {
                            case SpiderDirection.Left:
                                Direction = SpiderDirection.Up;
                                break;
                            case SpiderDirection.Right:
                                Direction = SpiderDirection.Down;
                                break;
                            case SpiderDirection.Up:
                                Direction = SpiderDirection.Right;
                                break;
                            case SpiderDirection.Down:
                                Direction = SpiderDirection.Left;
                                break;

                        }
                        break;
                }

        }
    }
}
