using SocialMediaTask;

public static class Program
{
    public static void Main()
    {
        SocialMedia linkedin = new SocialMedia();
        linkedin.AddFriend("Oktay", new List<string> { "salam", "aleykum", "necesen" });
        linkedin.AddFriend("AYhan", new List<string> { "salam", "sen", "netersen" });
        linkedin.RemoveFriend("Ayhan");
        linkedin.GetAllFriendsByUsername("Oktay");
        Console.ReadLine();
    }
}