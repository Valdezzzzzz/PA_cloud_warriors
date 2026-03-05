namespace alpha;

public class Quest
{
    public string Description;
    public int ID;
    public string Name;

    public Quest(int IDValue, string DescriptionValue, string NameValue)
    {
        Description = DescriptionValue;
        ID = IDValue;
        Name = NameValue;
    }
}