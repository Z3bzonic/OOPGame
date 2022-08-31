namespace InterfacesGame.Business
{
    public class EntityPositions
    {
        /// <summary>
        /// A list of the Dictionary index position from various playing field entities
        /// </summary>
        ///

        public List<int> rocks;
        public List<int> monsters;
        public List<int> rockDestroyers;
        public List<int> player;

        public EntityPositions()
        {
            rocks = new List<int>();
            monsters = new List<int>();
            rockDestroyers = new List<int>();
            player = new List<int>();
        }
    }
}