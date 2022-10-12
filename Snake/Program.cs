using System.Diagnostics;
using System.Reflection;
using Snake;

Boolean StillPlay = true;

List <Player> PlayerList = new List<Player>();

PlayerList.Add(new Player("Bastien"));
PlayerList.Add(new Player("JP"));

while (StillPlay)
{
    foreach (Player player in PlayerList)
    {
        StillPlay = PlayTurnAndReturnStillPlay(player);
        if (!StillPlay)
            break;
    }
}

static Boolean PlayTurnAndReturnStillPlay(Player player)
{
    player.Score = RollDiceAndAdd(player.Score);
    if (player.Score > 50)
        player.Score = 25;
    else if (player.Score == 50)
    {
        Console.WriteLine(player.Name + " WIN");
        return false;
    }
    return true;
}

static int RollDiceAndAdd(int PlayerScore)
{
	Random Rnd = new Random();
	int Dice = Rnd.Next(6);
	return PlayerScore + Dice;
}
