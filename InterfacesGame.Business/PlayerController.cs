using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class PlayerController
    {
        private Field _field;
        private Player _player;
        private SingleTile _singleTile;

        public PlayerController(Field field, Player player, SingleTile singleTile)
        {
            _field = field;
            _player = player;
            _singleTile = singleTile;
        }

        public void ControlPlayer()
        {
            var key = Console.ReadKey();
            ChangeDirection(key);
        }

        private void ChangeDirection(ConsoleKeyInfo direction)
        {
            switch (direction.Key)
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
            if (CanMove(_player.Coordinates.Id - 20))
            {
                _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
                _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id - 20));
            }
        }

        private void GoDown()
        {
            if (CanMove(_player.Coordinates.Id + 20))
            {
                _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
                _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id + 20));
            }
        }

        private void GoLeft()
        {
            if (CanMove(_player.Coordinates.Id - 1))
            {
                _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
                _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id - 1));
            }
        }

        private void GoRight()
        {
            if (CanMove(_player.Coordinates.Id + 1))
            {
                _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
                _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id + 1));
            }
        }

        private bool CanMove(int indexId)
        {
            if (_field.indexOfMonsters.Contains(indexId))
                return false;
            if (_field.indexOfRockDestroyers.Contains(indexId))
                return false;
            if (_field.indexOfRocks.Contains(indexId))
                return false;
            if (Enumerable.Range(379, 399).Contains(indexId))
                return false;
            if (_field.boundryTilesList.Contains(indexId))
                return false;
            else
                return true;
        }
    }
}