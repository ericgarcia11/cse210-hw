public class Resume
{
     public string _personName;
     public object _personJob;

     public Resume()
    {
    }

    public void ShowJobInformation()
    {
            Console.WriteLine($"{_personName}");
    }
}