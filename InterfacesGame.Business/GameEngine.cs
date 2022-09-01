using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class GameEngine
    {
        private readonly Field _field;
        private readonly PlayerController _playerControl;
        private MonsterController _monsterControl;
        private Checks _check;
        private Player _player;

        public GameEngine(Field field, PlayerController playerControl, MonsterController monsterControl, Checks check)
        {
            _field = field;
            _playerControl = playerControl;
            _monsterControl = monsterControl;
            _check = check;
            _player = Player.GetPlayer();
        }

        public void LoopOver()
        {
            while (!_check.Victory && _check.Level < 4) // todo
            {
                _check.Victory = _check.CheckBoundry(_player.Coordinates.Id);
                _playerControl.ControlPlayer();
            }
        }
    }
}