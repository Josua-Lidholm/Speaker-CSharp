namespace Speaker_CSharp;

public class Speaker
{
    // Fields 
    private int volume;
    
    // Properties
    public int Volume
    {
        get { return volume; }
        set
        {
            if (value < 0)
            {
                volume = 0;
            }
            else if (value > 100)
            {
                volume = 100;
            }
            else
            {
                volume = value;
            }
        }
    }
    
    private int unmutedVolume { get; set; }

    public bool IsMuted => Volume == 0;
    
    // Methods

    public void VolumeUp()
    {
        Volume += 10;
    }
    
    public void VolumeDown()
    {
        Volume -= 10;
    }

    public void Mute()
    {
        unmutedVolume = Volume;

        Volume = 0;
    }

    public void Unmute()
    {
        Volume = unmutedVolume;
    }
    
    // Constructor
    public Speaker()
    {
        volume = 30;
    }

}