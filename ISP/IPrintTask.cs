public interface IPrintTask
{
    bool PrintContent(string content);
    bool ScanContent(string content);
    
    bool PhotoCopy(string content);
}

public interface IFaxContent{
    bool FaxContent(string content);
}