public class LectureEvent : Event
{
    private string _speaker;
    private string _limitedCapacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, string limitedCapacity) : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _limitedCapacity =  limitedCapacity;
    }

    public override string FullDetailedMessage()
    {
        return StandardMessage() + $"\nSpeaker: {_speaker}\nCapacity: {_limitedCapacity}\n";
    }
}