// See https://aka.ms/new-console-template for more information
int P1_Score = 0;
int P2_Score = 0;

Boolean isWin = false;

while (!isWin)
{
	P1_Score = RollDiceAndAdd(P1_Score);
	P2_Score = RollDiceAndAdd(P2_Score);

	if (P1_Score > 50)
	{
		P1_Score = 25;
	}
	else if (P2_Score > 50)
	{
		P2_Score = 25;
	}
	else if (P1_Score == 50 || P2_Score == 50)
	{
		isWin = true;
	}
}

if (P1_Score == 50) {
	Console.WriteLine("P1 WIN");
}
else {
	Console.WriteLine("P2 WIN");
}

static int RollDiceAndAdd(int Player_score)
{
	Random rnd = new Random();
	int dice = rnd.Next(6);
	return Player_score + dice;
}
