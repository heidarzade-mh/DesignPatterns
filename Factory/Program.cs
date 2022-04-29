// See https://aka.ms/new-console-template for more information

using System;
using Factory;

string cardType = "MoneyBack";
ICreditCard cardDetails = null;
//Based of the CreditCard Type we are creating the
//appropriate type instance using if else condition
if (cardType == "MoneyBack")
{
    cardDetails = new MoneyBack();
}
else if (cardType == "Titanium")
{
    cardDetails = new Titanium();
}
else if (cardType == "Platinum")
{
    cardDetails = new Platinum();
}
if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();