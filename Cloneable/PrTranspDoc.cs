using System.Reflection.PortableExecutable;

public class PrTranspDocClass : ITranspDoc<PrTranspDocClass>, ICloneable
{
    public PrTranspDocClass(string code, string num)
    {
        Code = code;
        NumTs = num;

    }
    public string Code { get; set; }
    public string NumTs { get; set; }

    private PrNameTSDocClass NameTs;
    public PrTranspDocClass MyClone()
    {
        return new PrTranspDocClass(Code, NumTs)
        {
            NumTs = this.NumTs,
            Code = this.Code
        };
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public override string ToString()
    {
        NameTs = new PrNameTSDocClass(Code);
        return $"Документ (Код:{Code}, Наименование:{NameTs.Name}, Номер:{NumTs})";
    }

}

