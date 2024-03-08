class Load
{
    public void Loading()
    {
        string[] slide = {"|", "/", "--", @"\"};
        int i = 0;
        int j = 0;

        while(i < 4 && j < 12)
        {
            Console.Clear();
            Console.WriteLine($"\n\n\n\n\t\tPlease wait {slide[i]}");
            System.Threading.Thread.Sleep(150);
            i++;

            if(i == 4)
                i = 0;
                j++;
        }
        Console.Clear();
    }
}