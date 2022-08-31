using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class MonsterController
    {
        private Field field;
        private EntityPositions pos;

        public MonsterController(Field field, EntityPositions pos)
        {
            this.field = field;
            this.pos = pos;
        }
    }
}