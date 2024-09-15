namespace Axolotl.Util;

public class EducationUriResource
{
    public string ButtonName { get; set; }
    public string LinkUri { get; set; }

    public EducationUriResource()
    {

    }

    public EducationUriResource(string buttonName, string linkUri)
    {
        ButtonName = buttonName;
        LinkUri = linkUri;
    }
}