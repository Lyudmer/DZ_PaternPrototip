using System.Diagnostics;

Console.WriteLine("ДЗ паттерн Прототип - Документы ");

var stopWatch = new Stopwatch();
stopWatch.Start();
PrDoc original = new()
{
    Id = 1,
    Number = "1111",
    Code = "04",
    DocDate = new DateTime(2021, 7, 20),
    VidTs  ="30", 
    NumTs="A123CC198",
    ConsigneeName = "АО ТАСКОМ",
    ConsigneeCr = "RU",
    ConsigneeAdr = "249020,КАЛУЖСКАЯ ОБЛАСТЬ,СЕЛО ВОРСИНО БОРОВСКИЙ Р-Н,СЕВЕРНАЯ ПРОМЫШЛЕННАЯ ЗОНА ВЛАДЕНИЕ 6 СТР 1",
    ConsignorName = "Иннер Монголия Азия Европа Интернешнл Логистикс Лимитед Ко.,Лтд",
    ConsignorCr = "CN",
    ConsignorAdr = "Компрехенсив Билдинг,Чайна Рэилвэй,Экспресс Хаб Лоджистикс Бэйз,Кисуму",
    CarrierName = "ОАО РОССИЙСКИЕ ЖЕЛЕЗНЫЕ ДОРОГИ",
    CarrierCr = "RU",
    CarrierAdr="107174,МОСКВА,НОВАЯ БАСМАННАЯ Д.2",
    Goods = "VENUS PREMIUM 1st grade/1 сорт Fabric furniture upholstery(100% polyester) \n ( код 5512199000,вес 2461.93, 5525.1 М2, стоимость 24123.58)",
    Signatory="таможенный брокер Казначеева Алена Геннадьевна"
};


Console.WriteLine("Исходный: {0}", original.ToString());
stopWatch.Stop();
Console.WriteLine($"Тест выполнился за {stopWatch.ElapsedMilliseconds}мс...");
stopWatch.Start();



stopWatch.Start();
var doc_ic_clone = original.Clone();
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Копия(Clone):{0}", doc_ic_clone.ToString());
stopWatch.Stop();
Console.WriteLine($"Тест выполнился за {stopWatch.ElapsedMilliseconds}мс...");

PrDoc doc_clone = original.MyClone();
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Копия(MyClone):{0}", doc_clone.ToString());
stopWatch.Stop();
Console.WriteLine($"Тест выполнился за {stopWatch.ElapsedMilliseconds}мс...");
Console.ReadKey();
