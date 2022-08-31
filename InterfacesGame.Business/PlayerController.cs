using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class PlayerController
    {
        private Field _field;
        private EntityPositions _pos;
        private Player _player;

        public PlayerController(Field field, EntityPositions pos, Player player)
        {
            _field = field;
            _pos = pos;
            _player = player;
        }

        public void ControlPlayer()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                ChangeDirection(key);
            }
        }

        private void ChangeDirection(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    GoUp();
                    break;

                case ConsoleKey.DownArrow:
                    GoDown();
                    break;

                case ConsoleKey.LeftArrow:
                    GoLeft();
                    break;

                case ConsoleKey.RightArrow:
                    GoRight();
                    break;
            }
        }

        private void GoUp()
        {
            Map<int> posupdate = _field.Tiles.ElementAt(_pos.player.ElementAt(0) - 20).Value;
            _player.RenderOnField(posupdate);
            _pos.player[0] = posupdate;
        }

        private void GoDown()
        {
            throw new NotImplementedException();
        }

        private void GoLeft()
        {
            throw new NotImplementedException();
        }

        private void GoRight()
        {
            throw new NotImplementedException();
        }
    }
}