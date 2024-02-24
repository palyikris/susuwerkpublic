
namespace HF1
{

    public enum Content
    {
        WALL,
        GHOST,
        TREASURE,
        EMPTY
    }

    public struct Direction
    {
        public int x, y;
    }
    public class Labirynth
    {
        private Content[,] map;

        public Labirynth(Content[,] map)
        {
            this.map = map;
        }

        public Content WhatIsThere(int x, int y, Direction dir) {
            

            int n = map.GetLength(x);
            int m = map.GetLength(y);

            if(!((x + dir.x >= 1 || x + dir.x <= n) && (y + dir.y >= 1  || y + dir.y <= m)) && (dir.x == 0 || dir.y == 0)) 
            {
                throw new Exception();
            }
            
            
            return map[x + dir.x, y + dir.y];
        }

        public void Collect(int x, int y)
        {
            if (map[x, y] != Content.TREASURE)
            {
                throw new Exception();
            }

            map[x, y] = Content.EMPTY;
        }
    }
}
