using System.ComponentModel;

class Post
{
    public string Text;
    public int Likes;
    List<string> Commments= new List<string>(){};
    public void SetPost(string text)
    {
        Text=text;
    }
    public void AddLike()
    {
        Likes++;
    }
    public void AddComments(string comment)
    {
        Commments.Add(comment);
    }
     
    public void GetInfo()
    {
        System.Console.WriteLine("Text = "+Text);
        System.Console.WriteLine("Likes: "+Likes);
        System.Console.WriteLine("Commments: ");
        for (int i = 0; i < Commments.Count; i++)
        {
            Console.WriteLine(Commments[i]);
        }
    }
    
}