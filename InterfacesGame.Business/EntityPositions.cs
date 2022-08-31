namespace InterfacesGame.Business
{
    public class EntityPositions
    {
        /// <summary>
        /// A list of the Dictionary index position from various playing field entities
        /// </summary>
        ///

        public IList<int> rocks;
        public IList<int> monsters;
        public IList<int> rockDestroyers;
        public IList<int> player;

        public EntityPositions()
        {
            rocks = new List<int>();
            monsters = new List<int>();
            rockDestroyers = new List<int>();
            player = new List<int>();
        }
    }
}