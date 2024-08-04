public class PrDoc : IDoc<PrDoc>,ICloneable
{
    public int Id { get; set; }
    public string Number { get; set; }
    public DateTime DocDate { get; set; }
    public string Code { get; set; } 
    public string VidTs { get; set; }
    public string NumTs { get; set; }
    public string ConsignorName { get; set; }
    public string ConsignorCr { get; set; }
    public string ConsignorAdr { get; set; }
    public string ConsigneeName { get; set; }
    public string ConsigneeCr { get; set; }
    public string ConsigneeAdr { get; set; }
    public string CarrierName { get; set; }
    public string CarrierCr { get; set; }
    public string CarrierAdr { get; set; }
    public string Goods { get; set; }
    public string Signatory { get; set; }

    private PrHeaderDocClass Header ;
    private PrTranspDocClass ResTransp;
    private PrBodyDocClass ResConsignor;
    private PrBodyDocClass ResConsignee;
    private PrBodyDocClass ResCarrier;
    private PrBodyDocClass ResGoods;
    private PrBodyDocClass ResSign;
    private string OrgText="";
    public object Clone()
    { 
        return this.MemberwiseClone();
    }
    public PrDoc MyClone()
    {
        return new PrDoc()
        {
            Id      = this.Id,
            Number  = this.Number,
            Code    = this.Code,
            VidTs = this.VidTs,
            NumTs = this.NumTs,
            DocDate = this.DocDate,
            ConsigneeName = this.ConsigneeName,
            ConsigneeCr = this.ConsigneeCr, 
            ConsigneeAdr = this.ConsigneeAdr,
            ConsignorName = this.ConsignorName,
            ConsignorCr = this.ConsignorCr,
            ConsignorAdr = this.ConsignorAdr,
            CarrierName = this.CarrierName,
            CarrierCr = this.CarrierCr,
            CarrierAdr = this.CarrierAdr,
            Goods = this.Goods,
            Signatory =this.Signatory
        };
    }
    public override string ToString()
    {
        Header = new PrHeaderDocClass(Code, Number, DocDate);
        ResTransp = new PrTranspDocClass(VidTs,NumTs);
        ResConsignor = new PrBodyDocClass("Отправитель ", new PrOrgDocClass(ConsignorName, ConsignorCr, ConsignorAdr).ToString());
        ResConsignee = new PrBodyDocClass("Получатель ", new PrOrgDocClass(ConsigneeName, ConsigneeCr, ConsigneeAdr).ToString());
        ResCarrier = new PrBodyDocClass("Перевозчик ", new PrOrgDocClass(CarrierName, CarrierCr, CarrierAdr).ToString());
        ResGoods = new PrBodyDocClass("Описание груза ", Goods);
        ResSign = new PrBodyDocClass("Документ составил и подписал", Signatory);

        return $"{Header} " +
               $"\n {ResTransp}" +
               $"\n {ResConsignor} " +
               $"\n {ResConsignee} " +
               $"\n {ResCarrier} " +
               $"\n {ResGoods}"+
                $"\n {ResSign}";
    }
}
