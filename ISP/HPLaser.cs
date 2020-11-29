public class HPLaser : IPrintTask,IFaxContent
{
    bool PrintContent(string content)
    {
        System.Console.WriteLine("PrintContent");
        return true;
    }
    bool ScanContent(string content)
    {
        System.Console.WriteLine("ScanContent");
        return true;
    }
    bool FaxContent(string content)
    {
        System.Console.WriteLine("FaxContent");
        return true;
    }
    bool PhotoCopy(string content)
    {
        System.Console.WriteLine("PhotoCopy");
        return true;
    }
}