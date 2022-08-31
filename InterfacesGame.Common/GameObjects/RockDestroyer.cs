using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class RockDestroyer : IPlaceOnField
    {
        public void RenderOnField(Map<int> coords)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('<');
        }
    }
}