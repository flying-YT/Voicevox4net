namespace Voicevox4net.Model;   

public class SpeakerModel
{
    public Supported_Features supported_features { get; set; }
    public string name { get; set; }
    public string speaker_uuid { get; set; }
    public Style[] styles { get; set; }
    public string version { get; set; }
}

public class Supported_Features
{
    public string permitted_synthesis_morphing { get; set; }
}

public class Style
{
    public string name { get; set; }
    public int id { get; set; }
}