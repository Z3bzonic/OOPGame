using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class InitializeGame
    {
        private Field _field;
        public Player _player;
        private Random _rnd;
        private const int ROCKS = 5; //todo
        private const int ROCKDESTROYERS = 5; //todo
        private const int MONSTERS = 5; //todo

        public InitializeGame(Field field, Player player)
        {
            _field = field;
            _rnd = new Random();
            _player = player;
        }

        public void PopulateMatrix()
        {
            _field.InitializeField();
            MakeRocks();
            MakeMonsters();
            MakeRockDestroyers();
            SpawnPlayer();
        }

        public void SpawnPlayer()
        {
            var randomStartPoint = _rnd.Next(379, 399);
            _player.RenderOnField(_field.Tiles.ElementAt(randomStartPoint));
        }

        private void MakeRocks()
        {
            for (int i = 0; i < ROCKS; i++)
            {
                var randomposition = PickRandomTile();
                var rock = new Rock();
                rock.RenderOnField(_field.Tiles.ElementAt(randomposition));
            }
        }

        private void MakeMonsters()
        {
            for (int i = 0; i < MONSTERS; i++)
            {
                var randomposition = PickRandomTile();
                var monster = new Monster();
                monster.RenderOnField(_field.Tiles.ElementAt(randomposition));
            }
        }

        private void MakeRockDestroyers()
        {
            for (int i = 0; i < ROCKDESTROYERS; i++)
            {
                var randomposition = PickRandomTile();
                var rockDestroyer = new RockDestroyer();
                rockDestroyer.RenderOnField(_field.Tiles.ElementAt(randomposition));
            }
        }

        private int PickRandomTile()
        {
            return _rnd.Next(21, 379);
        }
    }
}