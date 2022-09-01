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
            _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
            _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id - 20));
        }

        private void GoDown()
        {
            _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
            _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id + 20));
        }

        private void GoLeft()
        {
            _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
            _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id - 1));
        }

        private void GoRight()
        {
            _singleTile.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id));
            _player.RenderOnField(_field.Tiles.ElementAt(_player.Coordinates.Id + 1));
        }
    }
}