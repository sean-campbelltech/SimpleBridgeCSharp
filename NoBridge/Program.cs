// Client
using System.Globalization;
using System.Text.RegularExpressions;
using NoBridge;

CarInsurance comp1 = new SafeDriverComprehensiveCarInsurance(2023, "Mercedes-Benz", "E-Class");
CarInsurance thirdParty1 = new SafeDriverThirdPartyCarInsurance(2023, "VW", "Tiguan");
Console.WriteLine("Safe Driver Discounts:");
Console.WriteLine("----------------------");
Print(comp1);
Print(thirdParty1);

CarInsurance comp2 = new NoClaimsComprehensiveCarInsurance(2023, "Mercedes-Benz", "E-Class");
CarInsurance thirdParty2 = new NoClaimsThirdPartyCarInsurance(2023, "VW", "Tiguan");
Console.WriteLine("\nNo ClaimsDiscounts:");
Console.WriteLine("-------------------");
Print(comp2);
Print(thirdParty2);

static void Print(CarInsurance carInsurance)
{
    Console.WriteLine($"{PascalCaseToSentence(carInsurance.GetType().Name)} Premium: {carInsurance.Year} {carInsurance.Make} {carInsurance.Model} @ ${carInsurance.GetPremium():f2} p/m");
}

static string PascalCaseToSentence(string input)
{
    return Regex.Replace(input, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
}
