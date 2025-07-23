// LocationInfo.cs

public class LocationInfo
{
    public Location Location { get; }
    public int RequiredLevel { get; }
    public string LocationName { get; }

    public LocationInfo(Location location, int requiredLevel, string locationName)
    {
        Location = location;
        RequiredLevel = requiredLevel;
        LocationName = locationName;
    }
}