using System;
using System.Collections;

public class Word
{
    Reference workingRefferance = new Reference();
    private string[] _words;
    public string _visWords;
    private Stack hiddenWords = new Stack();
    private Stack hiddenPosition = new Stack();
    
    public void GetWords()
    {
        _visWords = workingRefferance.GetVerse();
    }

    public void SetWords()
    {
        _words = workingRefferance.SetVerse(_visWords);
    }

    public void DisplayVese()
    {
        foreach (string word in _words)
        {
            Console.Write(word);
            Console.Write(" ");
        }
    }

    public void HideWords()
    {
        int timesRun = 0;
        string wordToHide;

        while(timesRun < 3)
        {
            int legnthVerse = _words.Length;
            int legnthHiddenWords = hiddenWords.Count; 

            Random randomGenerator = new Random();
            int hiddenWord = randomGenerator.Next(0, legnthVerse);

            if (hiddenPosition.Contains(hiddenWord) == false)
            {
                timesRun += 1;
                hiddenPosition.Push(hiddenWord);
                wordToHide = _words[hiddenWord];
                _words[hiddenWord] = "_____";
                hiddenWords.Push(wordToHide);
            }
            else if(legnthVerse == legnthHiddenWords)
            {
                timesRun = 3;
            }
        }
    }

    public void RevealWords()
    {
        int timesRun = 0;
        string wordToShow;
        int shownPossition;

        while(timesRun <3)
        {
            timesRun += 1;
            shownPossition = (int)hiddenPosition.Pop();
            wordToShow = (string)hiddenWords.Pop();
            _words[shownPossition] = wordToShow;
            if(hiddenPosition.Count < 3)
            {
                timesRun = 3;
            }
        }
    }
}