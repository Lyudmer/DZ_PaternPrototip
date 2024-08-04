using System.Reflection.PortableExecutable;

public class PrHeaderDocClass : IHeaderDoc<PrHeaderDocClass>,ICloneable
{
    public PrHeaderDocClass(string code,string num,DateTime docdate)
    {
        Code = code;
        Number =num;
        DocDate=docdate;
    }
    public string Number { get; set; }
    public DateTime DocDate { get; set; }
    public string Code { get; set; }

   
    public PrHeaderDocClass MyClone()
    {
        return new PrHeaderDocClass(Code,Number,DocDate)
        {
            Number = this.Number,
            Code = this.Code,
            DocDate = this.DocDate
        };
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public override string ToString()
    {
        
        return $"{new PrNameDocClass(Code).Name} ({Code}) \n Номер {Number} дата  {DocDate.Date}";
    }

}

