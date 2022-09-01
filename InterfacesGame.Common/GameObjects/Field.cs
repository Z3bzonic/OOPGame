namespace InterfacesGame.Common.GameObjects
{
    public class Field
    {
        public IList<Map<int>> Tiles { get; set; }

        public Field()
        {
            Tiles = new List<Map<int>>();
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
        }

        private void RenderField(Map<int> coords)
        {
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('□');
        }
    }
}