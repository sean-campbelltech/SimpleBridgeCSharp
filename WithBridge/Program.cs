// Client
using System.Text.RegularExpressions;
using WithBridge;

SafeDriverDiscount safeDriverDiscount = new();
CarInsurance comp1 = new ComprehensiveCarInsurance(2023, "Mercedes-Benz", "E-Class", safeDriverDiscount);
CarInsurance thirdParty1 = new ThirdPartyCarInsurance(2023, "VW", "Tiguan", safeDriverDiscount);
Console.WriteLine("Safe Driver Discounts:");
Console.WriteLine("----------------------");
Print(comp1);
Print(thirdParty1);

NoClaimsDiscount noClaimsDiscount = new();
CarInsurance comp2 = new ComprehensiveCarInsurance(2023, "Mercedes-Benz", "E-Class", noClaimsDiscount);
CarInsurance thirdParty2 = new ThirdPartyCarInsurance(2023, "VW", "Tiguan", noClaimsDiscount);
Console.WriteLine("\nNo ClaimsDiscounts:");
Console.WriteLine("-------------------");
Print(comp2);
Print(thirdParty2);

static void Print(CarInsurance carInsurance)
{
    Console.WriteLine($"{PascalCaseToSentence(carInsurance.GetType().Name)} Premium: {carInsurance.Year} {carInsurance.Make} {carInsurance.Model} @ ${carInsurance.CalculatePremium():f2} p/m");
}

static string PascalCaseToSentence(string input)
{
    return Regex.Replace(input, "(\\B[A-Z])", " $1").Trim();
}