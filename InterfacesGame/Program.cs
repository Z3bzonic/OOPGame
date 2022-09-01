using InterfacesGame;
using InterfacesGame.Business;
using InterfacesGame.Common.GameObjects;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var menu = new Menu();
        var field = new Field();
        var player = Player.GetPlayer();
        var singleTile = SingleTile.GetSingleTile();
        var init = new InitializeGame(field, player);
        var playerControl = new PlayerController(field, player, singleTile);
        var monsterControl = new MonsterController(field);
        var checks = new Checks();
        var engine = new GameEngine(field, playerControl, monsterControl, checks);
        //int selection = menu.SelectMenu("Start", "Difficulty", "Highscores");
        init.PopulateMatrix();
        engine.LoopOver();
    }
}