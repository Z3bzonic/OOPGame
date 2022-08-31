namespace InterfacesGame.Common.GameObjects
{
    public struct Map<T>
    {
        public T X;
        public T Y;

        public Map(T x, T y) : this()
        {
            X = x;
            Y = y;
        }
    }
}