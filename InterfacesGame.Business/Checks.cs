namespace InterfacesGame.Business
{
    public class Checks : Conditions
    {
        public int Level { get; set; } = 1;
        public bool Victory { get; set; }

        public Checks()
        {
        }

        public override bool CheckBoundry(int indexNumber)
        {
            if (Enumerable.Range(1, 20).Contains(indexNumber))
                return true;
            else
                return false;
        }

        public bool DetectObstruction()
        {
            //Rock rocky = Rock.Coordinates.Id[0];
            return false;
        }
    }
}