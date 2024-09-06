// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Globalization;

const double COST_OF_SANDWHICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;


int numberOfSandwhiches = 0;
int numberOfToppings =0;

System.Console.WriteLine("How many Sandwhiches?");
numberOfSandwhiches= int.Parse(Console.ReadLine());
double totalSandwhichCost = COST_OF_SANDWHICH * numberOfSandwhiches;
System.Console.WriteLine( "Total " + totalSandwhichCost);


System.Console.WriteLine("How many Toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
System.Console.WriteLine( "Total " + totalToppingCost);

System.Console.WriteLine("Leave a tip?");
double tip =0;
Console.ReadLine();


double baseCost = totalSandwhichCost + totalToppingCost;
double orderCost = tip + baseCost * (1 - DISCOUNT_AMOUNT);

System.Console.WriteLine("TOTAL " + orderCost);







