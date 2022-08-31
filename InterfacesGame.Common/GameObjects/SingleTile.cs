using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    internal class SingleTile : IPlaceOnField
    {
        public void RenderOnField(Map<int> coords)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('⛋');
        }
    }
}