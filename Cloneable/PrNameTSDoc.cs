public class PrNameTSDocClass 
{
    public PrNameTSDocClass(string code)
    {
        Code = code;
    }
    private string nTs;
    public string Name
    {
        get 
        {
            switch (Code)
            {
                case "10":
                    nTs = "Самолет";
                    break;
                case "20":
                    nTs = "ЖД Вагон";
                    break;
                case "30":
                    nTs = "Тягач";
                    break;
                case "40":
                    nTs = "Контейнеровоз";
                    break;
                default:
                    nTs = "Свом ходом";
                    break;
            }
            return nTs; 
        }
    }
    public string Code { get; }
  
}

