namespace InterfacesGame.Business
{
    public class VictoryAndLevel : Conditions
    {
        public int Level { get; set; } = 1;
        public bool Victory { get; set; }

        public VictoryAndLevel()
        {
        }

        public override bool CheckBoundry(int index)
        {
            if (Enumerable.Range(1, 20).Contains(index))
                return true;
            else
                return false;
        }

        public bool DetectObstruction()
        {
            return false;
        }
    }
}