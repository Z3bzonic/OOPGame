using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class Monster : IPlaceOnField
    {
        public void RenderOnField(Map<int> coords)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('°');
        }
    }
}