using System;
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
        bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
        bool isIE = browser.ToUpper().IndexOf("IE") > -1;
        bool wasResized = resize > 0;

        if (isMacOs && isIE && wasInitialized() && wasResized)
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