using System;
using System.IO;
public class Reference
{
    private string _verse;
    public string visVerse;
    //private string scriptReferance;
    public string visChapter;
    //private string _book;
    public string visBook;
    string filename = "scripture.txt";
    //string[] referance = new string[1];
    string[] referance = ["And", "he", "was", "withdrawn", "from", "them", "about", "a", "stone’s", "cast,", "and", "kneeled", "down,", "and", "prayed,",
"Saying,", "Father,", "if", "thou", "be", "willing,", "remove", "this", "cup", "from", "me:", "nevertheless", "not", "my", "will,", "but", "thine,", "be", "done.",
"And", "there", "appeared", "an", "angel", "unto", "him", "from", "heaven,", "strengthening", "him.",
"And", "being", "in", "an", "agony", "he", "prayed", "more", "earnestly:", "and", "his", "sweat", "was", "as", "it", "were", "great", "drops", "of", "blood", "falling", "down", "to", "the", "ground."];

    public string GetVerse()
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Please enter the words of verse you would like to memorize:");
            visVerse = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Ready to pull from file.");
        }

        return visVerse;
    }

    public void GetRefferance()
    {
        Console.WriteLine("Please enter the book:");
        visBook = Console.ReadLine();
        Console.WriteLine("Please enter the chapter and verses:");
        visChapter = Console.ReadLine();
    }

    public string[] SetVerse(string VisVerse)
    {
        if (!File.Exists(filename))
        {
            _verse = VisVerse;
            referance = _verse.Split(" ");
        }
        else
        {
            //string line;
            //char[] separators = [' ', '.'];

            //StreamReader sr = new(filename);
            //line = sr.ReadLine();
            //visBook = line;
            //while (line != null)
            //{
            //    line = sr.ReadLine();
            //    string[] lineToAdd = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //    foreach (string word in lineToAdd)
            //    {
            //        referance.Append(word).ToArray();
            //    }
            //}
            //foreach (string refer in referance)
            //    {
            //        Console.WriteLine(refer);
            //    }
            //sr.Close();
        }

        return referance;
        
    }

    public void SetRefferance()
    {
        
    }
}