using System;
public class Journal
{
    public string input = "";
    string fileName = "journal.txt";
    string date = DateTime.Today.ToString("dd/MM/yyyy");
    public string EnteryWrite()
    {
        Entrey entery1 = new Entrey();
        input = entery1.NewEntery();

        return input;
    }

    public void EnteryRead()
    {
        Console.WriteLine(date);
        Console.Write(input);
    }

    public void Save()
    {
        if (!File.Exists(fileName))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(date);
                sw.Write(input);
            }	
        }
        else
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(date);
                sw.Write(input);
            }
        }
    
    }

    public void Load()
    {
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}