// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.JavaScript;
using Speaker_CSharp;

Speaker JBL = new Speaker();

while (true)
{
    int volumeSegment = JBL.Volume / 10;
    string filled = new string('#', volumeSegment);
    string unfilled = new string('-', 10 - volumeSegment);
    
    Console.Clear();

    Console.WriteLine($"Volume: [{filled}{unfilled}]");
    
    // Console.WriteLine($"Muted: {JBL.IsMuted}");
    
    Console.WriteLine("Commands:");
    Console.WriteLine("Up");
    Console.WriteLine("Down");
    Console.WriteLine("Mute");
    Console.WriteLine("Exit");

    var input = Console.ReadLine();

    Console.Clear();

    if (input.ToUpper() == "Up".ToUpper())
    {
        JBL.VolumeUp();
    }
    else if (input.ToUpper() == "Down".ToUpper())
    {
        JBL.VolumeDown();
    }
    else if (input.ToUpper() == "Mute".ToUpper())
    {
        if (JBL.IsMuted)
        {
            JBL.Unmute();
        }
        else
        {
            JBL.Mute();
        }
    }
    else if (input.ToUpper() == "Exit".ToUpper())
    {
        break;
    }
}