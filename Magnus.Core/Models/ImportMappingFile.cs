namespace Magnus.Core.Model;

public class ImportMappingFile
{
    public int ClientID { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public int FileTypeID { get; set; }
    public string FileType { get; set; } = string.Empty;
}
