using System;

namespace Maze
{
    public class MazeClass
    {
        public static int[,] Spiralize(int size)
        {
            if (size < 5)
                throw new InvalidSize();

            //Create the array
            int[,] maze = new int[size, size];
            int firstRow = 0;
            int lastRow = size - 1;
            int firstColumn = 0;
            int lastColumn = size - 1;

            void MoveRight()
            {
                for (int i = firstColumn; i < lastColumn; i++)
                    maze[firstRow, i] = 1;
                
            }
            void MoveDown()
            {
                for (int i = firstRow; i <= lastRow; i++)
                    maze[i, lastColumn] = 1;
                
            }
            void MoveLeft()
            {
                for (int i = lastColumn; i > firstColumn; i--)
                    maze[lastRow, i] = 1;
                
            }
            void MoveUp()
            {
                for (int i = lastRow; i >= firstRow; i--)
                    maze[i, firstColumn] = 1;
            }
            void Navigation()
            {
                MoveRight();
                MoveDown();
                MoveLeft();
                for (int i = 0; i < size / 2; i++)
                {
                    firstRow += 2;
                    lastColumn -= 2;
                    MoveUp();
                    firstColumn += 1;
                    lastRow -= 2;
                    MoveRight();
                    firstColumn += 1;
                    MoveDown();
                    MoveLeft();
                }
            }

            Navigation();
            return maze;


        }
        public class InvalidSize : Exception { }
    }
}
