using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class Rock : IPlaceOnField
    {
        public Map<int> Coordinates { get; set; }

        public void RenderOnField(Map<int> coords)
        {
            Coordinates = coords;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('■');
        }
    }
}