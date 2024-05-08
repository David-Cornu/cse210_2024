public class Resume
{
    public string _name = "";
    public new List<Job> _jobs = new();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs :");

        foreach (Job job in _jobs)
        {
            job.Display();
        } 
    }
}