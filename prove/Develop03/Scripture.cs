class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideRandomWords(int numberToHide)
{
    var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
    int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

    for (int i = 0; i < wordsToHide; i++)
    {
        visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            break;
        }
        int index = _random.Next(visibleWords.Count);
        visibleWords[index].Hide(); 
    }
}


    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
    return _words.All(word => word.IsHidden());
    }
}
