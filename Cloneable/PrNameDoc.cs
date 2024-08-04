public class PrNameDocClass  
{
    public PrNameDocClass(string code)
    {
        Code = code;
    }
    private string nDoc;
    public string Name
    {
        get 
        {
            switch (Code)
            {
                case "02":
                    nDoc = "Накладная";
                    break;
                case "04":
                    nDoc = "Инвойс";
                    break;
                case "06":
                    nDoc = "Сертификат";
                    break;
                default:
                    nDoc = "Доп.документ";
                    break;
            }
            return nDoc;
        }
    }
    public string Code { get; }

    
}

