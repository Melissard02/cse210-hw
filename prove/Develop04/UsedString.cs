//UsedString.cs

class UsedString
{
    private string _prompt;
    private bool _beenUsed;

    public UsedString(string prompt, bool hidden)
    {
        _prompt = prompt;
        _beenUsed = hidden;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetBeenUsed(bool value)
    {
        _beenUsed = value;
    }

    public bool GetBeenUsed()
    {
        return _beenUsed;
    }
}