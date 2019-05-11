using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figura> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figura>();

            HorizontalLines linexu = new HorizontalLines(0, mapWidth, 1, '+');
            HorizontalLines linexd = new HorizontalLines(0, mapWidth, mapHeight, '+');
            VertikalLines lineyl = new VertikalLines(1, mapHeight, 0, '+');
            VertikalLines lineyr = new VertikalLines(1, mapHeight, mapWidth, '+');
            wallList.Add(linexu);
            wallList.Add(linexd);
            wallList.Add(lineyl);
            wallList.Add(lineyr);
        }

        internal bool IsHit(Figura figura)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figura))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }


    }
}