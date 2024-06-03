using System;

public class Scripture
{
    Word workingwords = new Word();

    public void CreatScripture()
    {
        workingwords.GetWords();
        workingwords.SetWords();
    }

    public void Display()
    {
        workingwords.DisplayVese();
    }

    public void Hide()
    {
        workingwords.HideWords();
    }

    public void Show()
    {
        workingwords.RevealWords();
    }
}