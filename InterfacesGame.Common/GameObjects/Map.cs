namespace InterfacesGame.Common.GameObjects
{
    public struct Map<T>
    {
        public int Id { get; set; }
        public T X;
        public T Y;

        public Map(T x, T y) : this()
        {
            X = x;
            Y = y;
        }
    }
}