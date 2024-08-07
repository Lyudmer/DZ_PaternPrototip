using System.Reflection.PortableExecutable;

public class PrTranspDocClass : IDocInfo<PrTranspDocClass>, ICloneable
{
    public PrTranspDocClass(string code, string num)
    {
        Code = code;
        NumTs = num;

    }
    public string Code { get; set; }
    public string NumTs { get; set; }

  
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
        return $"{new PrNameTSDocClass(Code).Name}({Code}) \n Номер:{NumTs}";
    }

}

