// Client
using System.Text.RegularExpressions;
using NoBridge;

CarInsurance comp1 = new SafeDriverComprehensive(2023, "Mercedes-Benz", "E-Class");
CarInsurance thirdParty1 = new SafeDriverThirdParty(2023, "VW", "Tiguan");
CarInsurance propDamage1 = new SafeDriverPropertyDamage(2023, "Cadillac", "Escalade");
Console.WriteLine("Safe Driver Discounts:");
Console.WriteLine("----------------------");
Print(comp1);
Print(thirdParty1);
Print(propDamage1);

CarInsurance comp2 = new NoClaimsComprehensive(2023, "Mercedes-Benz", "E-Class");
CarInsurance thirdParty2 = new NoClaimsThirdParty(2023, "VW", "Tiguan");
CarInsurance propDamage2 = new NoClaimsPropertyDamage(2023, "Cadillac", "Escalade");
Console.WriteLine("\nNo Claims Discounts:");
Console.WriteLine("--------------------");
Print(comp2);
Print(thirdParty2);
Print(propDamage2);

CarInsurance comp3 = new AutoOwnersComprehensive(2023, "Mercedes-Benz", "E-Class");
CarInsurance thirdParty3 = new AutoOwnersThirdParty(2023, "VW", "Tiguan");
CarInsurance propDamage3 = new AutoOwnersPropertyDamage(2023, "Cadillac", "Escalade");
Console.WriteLine("\nAuto Owners Discounts:");
Console.WriteLine("----------------------");
Print(comp3);
Print(thirdParty3);
Print(propDamage3);

static void Print(CarInsurance carInsurance)
{
    Console.WriteLine($"{PascalCaseToSentence(carInsurance.GetType().Name)} Premium: {carInsurance.Year} {carInsurance.Make} {carInsurance.Model} @ ${carInsurance.GetPremium():f2} p/m");
}

static string PascalCaseToSentence(string input)
{
    return Regex.Replace(input, "(\\B[A-Z])", " $1").Trim();
}
