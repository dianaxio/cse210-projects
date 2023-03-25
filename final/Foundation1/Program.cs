using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];
    
        _videos[0] =  new Video("Download and Install Super Smash Bros Crusade V0.9.2 [MEGA]","Dianaxio",238);
        _videos[0].AddComment("Hinata ರ_ರ","Thank you, now I can play with my siblings ;D");
        _videos[0].AddComment("DarkRock","I like, it is good");
        _videos[0].AddComment("Alone","If smash flash is cool crusade surpasses it Thanks for the video keep doing it!");
    
        _videos[1] =  new Video("SPIRIT BREAKER IS NOT A SUPPORT HERO ANYMORE","Xiomara",1137);
        _videos[1].AddComment("Aquamarine Production","When the world needed him the most, he delivered. Tnx Sensei <3");
        _videos[1].AddComment("Orochimaru","This is not spirit breaker... This is Barathrum");
        _videos[1].AddComment("Nikki","Man i love when Rizpol using SB, gotta find new way");
        _videos[1].AddComment("Ali","Happiness is when rizpol up new vids");    

        _videos[2] =  new Video("ASMR Cranial Nerve Exam Roleplay With Dr Kenshi","ASMR Kenshi",1081);
        _videos[2].AddComment("BruhPlease","Relaxing! Love the video");
        _videos[2].AddComment("Hanczik","Pretty great video, loved the hearing test part!");
        _videos[2].AddComment("Lucie Buchet","Wow that was great !");

        _videos[3] =  new Video("New Super Mario Bros Wii - Complete Walkthrough","Typhlosion4President",17291);
        _videos[3].AddComment("Jhon Paletta","Nostalgia!! I had a Wii when I was 12 and always played this!!");
        _videos[3].AddComment("Juan Plummer","I got New Super Mario Bros. Wii on my birthday when I was 7.");
        _videos[3].AddComment("Liam Jake","Final score: 4,539,840 points. Awesome!");
        _videos[3].AddComment("Oscar Fargas","Nintendo's New Super Mario Bros. Wii for the Wii");    

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoData();
        }
    }
}