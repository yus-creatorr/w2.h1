class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;

    public void ScoreGoal()
    {
        System.Console.WriteLine("Player " + Name + " " + Number + " score a goal");
    }
    public void AssistGoal()
    {
        System.Console.WriteLine("Player "+Name+" "+"assist a goal for Neymar");
    }
    public void GetInfo()
    {
        System.Console.WriteLine("Enter player's name: "+ Name);
        System.Console.WriteLine("Enter player's number: "+ Number);
        System.Console.WriteLine("Enter player's possition: "+Position);
        System.Console.WriteLine("Enter player's team: "+Team);
    }
}