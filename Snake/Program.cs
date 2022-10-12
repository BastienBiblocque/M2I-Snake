// See https://aka.ms/new-console-template for more information
using Snake;

Player P1 = new Player("Bastien");
Player P2 = new Player("JP");

Boolean isWin = false;

while (!isWin)
{
	P1.Score = RollDiceAndAdd(P1.Score);
	P2.Score = RollDiceAndAdd(P2.Score);

	if (P1.Score > 50)
	{
		P1.Score = 25;
	}
	else if (P2.Score > 50)
	{
		P2.Score = 25;
	}
	else if (P1.Score == 50 || P2.Score == 50)
	{
		isWin = true;
	}
}

if (P1.Score == 50) {
	Console.WriteLine(P1.Name + " WIN");
}
else {
	Console.WriteLine(P2.Name + " WIN");
}

static int RollDiceAndAdd(int Player_score)
{
	Random rnd = new Random();
	int dice = rnd.Next(6);
	return Player_score + dice;
}
