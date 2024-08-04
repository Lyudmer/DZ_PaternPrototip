using System.Reflection.PortableExecutable;

public class PrOrgDocClass : IOrgDoc<PrOrgDocClass>,ICloneable
{
    public PrOrgDocClass(string name,string countrycode, string address)
    {
        Code = countrycode;
        Name = name;
        Address=address;
    
    }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    private PrNameCountryDocClass NameCr;
    public PrOrgDocClass MyClone()
    {
        return new PrOrgDocClass(Name,Code,Address)
        {
            Name = this.Name,
            Address = this.Address
        };
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public override string ToString()
    {
        NameCr = new PrNameCountryDocClass(Code);
        return $" Наименование:{Name}, Адрес:{NameCr.Name},{Address} ";
    }

}

