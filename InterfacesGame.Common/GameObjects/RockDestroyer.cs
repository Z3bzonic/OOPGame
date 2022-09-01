using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class RockDestroyer : IPlaceOnField
    {
        public Map<int> Coordinates { get; set; }

        public void RenderOnField(Map<int> coords)
        {
            Coordinates = coords;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('<');
        }
    }
}