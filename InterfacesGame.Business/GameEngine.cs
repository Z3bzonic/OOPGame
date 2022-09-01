using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class GameEngine
    {
        private Field _field;
        private readonly PlayerController _playerControl;
        private MonsterController _monsterControl;
        private VictoryAndLevel _victoryAndLevels;
        private Player _player;

        public GameEngine(Field field, PlayerController playerControl, MonsterController monsterControl, VictoryAndLevel victoryAndLevels)
        {
            _field = field;
            _playerControl = playerControl;
            _monsterControl = monsterControl;
            _victoryAndLevels = victoryAndLevels;
            _player = Player.GetPlayer();
        }

        public void LoopOver()
        {
            while (!_victoryAndLevels.Victory && _victoryAndLevels.Level < 4) // todo
            {
                _victoryAndLevels.Victory = _victoryAndLevels.CheckBoundry(_player.Coordinates.Id);
                _playerControl.ControlPlayer();
            }
        }
    }
}