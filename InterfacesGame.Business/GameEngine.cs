using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class GameEngine
    {
        private Field _field;
        private readonly PlayerController _playerControl;
        private MonsterController _monsterControl;
        private VictoryAndLevel _victoryAndLevels;
        private readonly EntityPositions _positions;

        public GameEngine(Field field, PlayerController playerControl, MonsterController monsterControl, VictoryAndLevel victoryAndLevels, EntityPositions positions)
        {
            _field = field;
            _playerControl = playerControl;
            _monsterControl = monsterControl;
            _victoryAndLevels = victoryAndLevels;
            _positions = positions;
        }

        public void LoopOver()
        {
            while (true)
            {
                _playerControl.ControlPlayer();
            }
        }
    }
}