using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class SingleTile : IPlaceOnField
    {
        private static SingleTile _singleTile;
        public Map<int> Coordinates { get; set; }

        public SingleTile()
        {
        }

        public void RenderOnField(Map<int> coords)
        {
            Coordinates = coords;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('X');
        }

        public static SingleTile GetSingleTile()
        {
            if (_singleTile == null)
            {
                _singleTile = new SingleTile();
            }
            return _singleTile;
        }
    }
}