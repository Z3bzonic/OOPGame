using InterfacesGame.Business;
using InterfacesGame.Common.GameObjects;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var field = new Field();
        var pos = new EntityPositions();
        var init = new InitializeGame(field, pos);
        var player = new Player();
        var playerControl = new PlayerController(field, pos, player);
        var monsterControl = new MonsterController(field, pos);
        var victoryAndLevels = new VictoryAndLevel();
        var engine = new GameEngine(field, playerControl, monsterControl, victoryAndLevels, pos);
        init.PopulateMatrix();
        engine.LoopOver();
    }
}