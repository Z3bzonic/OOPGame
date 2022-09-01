using System.Security.Cryptography.X509Certificates;

namespace InterfacesGame.Common.GameObjects
{
    public class Field
    {
        public IList<Map<int>> Tiles { get; set; }
        public List<int> indexOfRocks { get; set; }
        public List<int> indexOfRockDestroyers { get; set; }
        public List<int> indexOfMonsters { get; set; }
        public int[] boundryTilesList { get; set; }

        public Field()
        {
            Tiles = new List<Map<int>>();
            indexOfRocks = new List<int>();
            indexOfRockDestroyers = new List<int>();
            indexOfMonsters = new List<int>();
            boundryTilesList = new int[59];
        }

        public void InitializeField()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            const int _numberOfTiles = 40;
            var id = 0;
            for (var i = 0; i < _numberOfTiles; i += 2)
            {
                for (var y = 0; y < _numberOfTiles * 2; y += 4)
                {
                    var temp = new Map<int>(y, i);
                    temp.Id = id;
                    RenderField(temp);
                    Tiles.Add(temp);
                    id++;
                }
            }
            InitializeBoundries();
        }

        private void InitializeBoundries()
        {
            var count = 0;
            for (int i = 0; i < Tiles.Count * 2; i += 20)
            {
                if (count < 40)
                {
                    boundryTilesList[count] += i;
                }
                if (count > 2 && count < 39)
                {
                    boundryTilesList[count + 1] += i - 1;
                }
                count++;
                count++;
            }
            count = 399;
            for (int k = 40; k < 59; k++)
            {
                boundryTilesList[k] = count;
                count--;
            }
            ColorBorder();
        }

        private void ColorBorder()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var bound in boundryTilesList)
            {
                RenderField(Tiles.ElementAt(bound));
            }
        }

        private void RenderField(Map<int> coords)
        {
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('□');
        }
    }
}