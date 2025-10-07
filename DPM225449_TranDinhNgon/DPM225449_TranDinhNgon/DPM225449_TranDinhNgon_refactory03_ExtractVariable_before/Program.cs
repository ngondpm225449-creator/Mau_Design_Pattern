using System.Drawing;

class Program
{
    string platform = "MacOS";
    string browser = "IE11";
    int resize = 1;

    bool wasInitialized()
    {
        return true;
    }

    void RenderBanner()
    {
        if ((platform.ToUpper().IndexOf("MAC") > -1) &&
             (browser.ToUpper().IndexOf("IE") > -1) &&
              wasInitialized() && resize > 0)
        {
            // do something
            Console.WriteLine("Banner rendered!");
        }
    }

    static void Main()
    {
        Program program = new Program();
        program.RenderBanner();
    }
}