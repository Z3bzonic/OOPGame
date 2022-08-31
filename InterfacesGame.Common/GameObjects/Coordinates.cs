namespace InterfacesGame.Common.GameObjects
{
    public struct Map<T>
    {
        public int X;
        public int Y;

        public Map(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}