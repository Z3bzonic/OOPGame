namespace InterfacesGame.Common.GameObjects
{
    public class Field
    {
        public Dictionary<int, Map<int>> Tiles { get; set; }

        public Field()
        {
            Tiles = new Dictionary<int, Map<int>>();
        }

        public void InitializeField()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WindowHeight = 40;
            Console.WindowWidth = 80;
            var numberOfTiles = 40;
            var z = 0;
            for (var y = 0; y < numberOfTiles; y += 2)
            {
                for (var i = 0; i < numberOfTiles * 2; i += 4)
                {
                    var temp = new Map<int>(i, y);
                    RenderField(temp);
                    Tiles.Add(z, temp);
                    z++;
                }
            }
        }

        private void RenderField(Map<int> coords)
        {
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('□');
        }
    }
}