using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class Player : IPlaceOnField
    {
        private static Player _player;

        private Player()
        {
        }

        public Map<int> Coordinates { get; set; }

        public void RenderOnField(Map<int> coords)
        {
            Coordinates = coords;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('&');
        }

        public static Player GetPlayer()
        {
            if (_player == null)
            {
                _player = new Player();
            }
            return _player;
        }
    }
}