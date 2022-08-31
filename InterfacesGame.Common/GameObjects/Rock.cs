using InterfacesGame.Common.Interfaces;

namespace InterfacesGame.Common.GameObjects
{
    public class Rock : IPlaceOnField
    {
        public void RenderOnField(Map<int> coords)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(coords.X, coords.Y);
            Console.Write('■');
        }
    }
}