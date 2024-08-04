public class PrNameCountryDocClass 
{
    public PrNameCountryDocClass(string code)
    {
        Code = code;
    }
    private string nameCr;
    public string Name
    {
        get 
        {
            switch (Code)
            {
                case "RU":
                    nameCr = "Россия";
                    break;
                case "CN":
                    nameCr = "Китай";
                    break;
                case "BY":
                    nameCr = "БЕЛАРУСЬ";
                    break;
                case "KG":
                    nameCr = "КИРГИЗИЯ";
                    break;
                case "KZ":
                    nameCr = "КАЗАХСТАН";
                    break;
                case "AM":
                    nameCr = "АРМЕНИЯ";
                    break;
                default:
                    nameCr = "";
                    break;
            }
            return nameCr; 
        }
    }
    public string Code { get; }

    
}
