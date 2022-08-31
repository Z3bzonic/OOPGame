using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Business
{
    public class InitializeGame
    {
        private Field _field;
        public Player _player;
        private Random _rnd;
        private EntityPositions _pos;
        private const int ROCKS = 5;
        private const int ROCKDESTROYERS = 5;
        private const int MONSTERS = 5;

        public InitializeGame(Field field, EntityPositions positions)
        {
            _field = field;
            _rnd = new Random();
            _pos = positions;
            _player = new Player();
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
            _pos.player.Add(randomStartPoint);
            _player.RenderOnField(_field.Tiles.ElementAt(randomStartPoint).Value);
        }

        private void MakeRocks()
        {
            for (int i = 0; i < ROCKS; i++)
            {
                var randomposition = PickRandomTile();
                _pos.rocks.Add(randomposition);
                var rock = new Rock();
                rock.RenderOnField(_field.Tiles.ElementAt(randomposition).Value);
            }
        }

        private void MakeMonsters()
        {
            for (int i = 0; i < MONSTERS; i++)
            {
                var randomposition = PickRandomTile();
                _pos.monsters.Add(randomposition);
                var monster = new Monster();
                monster.RenderOnField(_field.Tiles.ElementAt(randomposition).Value);
            }
        }

        private void MakeRockDestroyers()
        {
            for (int i = 0; i < ROCKDESTROYERS; i++)
            {
                var randomposition = PickRandomTile();
                _pos.rockDestroyers.Add(randomposition);
                var rockDestroyer = new RockDestroyer();
                rockDestroyer.RenderOnField(_field.Tiles.ElementAt(randomposition).Value);
            }
        }

        private int PickRandomTile()
        {
            return _rnd.Next(21, 379);
        }
    }
}