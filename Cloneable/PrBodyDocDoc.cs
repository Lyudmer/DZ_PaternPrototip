
using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class PrBodyDocClass : IDocInfo<PrBodyDocClass>,ICloneable
{
    public PrBodyDocClass(string typestr, string textstr)
    {
        TypeStr = typestr;
        TextStr = textstr;
    }
    public string TypeStr { get; set; }
    public string TextStr { get; set; }
    public PrBodyDocClass MyClone()
    {
        
        return new PrBodyDocClass(TypeStr,TextStr)
        {
            TypeStr = this.TypeStr,
            TextStr = this.TextStr
        };
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public override string ToString()
    {
        if (TypeStr == null && TextStr == null) return "";
        else   return $"{TypeStr}:\n {TextStr}";
    }
}