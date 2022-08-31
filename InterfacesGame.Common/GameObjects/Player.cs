using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class Player : IPlaceOnField
    {
        public void RenderOnField(Map<int> coords)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('&');
        }
    }
}