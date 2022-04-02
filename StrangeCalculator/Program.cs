using StrangeCalculator;

Console.WriteLine("Enter a string number: ");
string String = Console.ReadLine();
int op1 = 0, op2 = 0;

for (int i = 0; i < 10; i++)
{
    String = String.Replace("  ", " ");
}
String = String.Trim();
String = String.ToLower();
int index = String.IndexOf(" ");
int secIndex = String.LastIndexOf(" ");
string first = String.Substring(0, index);
string oper = String.Substring(index + 1, 1);
string second = String.Substring(secIndex + 1, String.Length - secIndex - 1);
double result = 0;

switch (first)
{
    case "one":
        op1 = (int)Number.One;
        break;
    case "two":
        op1 = (int)Number.Two;
        break;
    case "three":
        op1 = (int)Number.Three;
        break;
    case "four":
        op1 = (int)Number.Four;
        break;
    case "five":
        op1 = (int)Number.Five;
        break;
    case "six":
        op1 = (int)Number.Six;
        break;
    case "seven":
        op1 = (int)Number.Seven;
        break;
    case "eight":
        op1 = (int)Number.Eight;
        break;
    case "nine":
        op1 = (int)Number.Nine;
        break;
}
switch (second)
{
    case "one":
        op2 = (int)Number.One;
        break;
    case "two":
        op2 = (int)Number.Two;
        break;
    case "three":
        op2 = (int)Number.Three;
        break;
    case "four":
        op2 = (int)Number.Four;
        break;
    case "five":
        op2 = (int)Number.Five;
        break;
    case "six":
        op2 = (int)Number.Six;
        break;
    case "seven":
        op2 = (int)Number.Seven;
        break;
    case "eight":
        op2 = (int)Number.Eight;
        break;
    case "nine":
        op2 = (int)Number.Nine;
        break;
}
switch (oper)
{
    case "+":
        result = op1 + op2;
        break;
    case "-":
        result = op1 - op2;
        break;
    case "*":
        result = op1 * op2;
        break;
    case "/":
        result = op1 / op2;
        break;

}
string sResult = "";
if (result < 0)
{
    sResult += "-";
}
switch (Math.Abs(result))
{
    case 0:
        sResult = "Zero";
        break;
    case 1:
        sResult += "One";
        break;
    case 2:
        sResult += "Two";
        break;
    case 3:
        sResult += "Three";
        break;
    case 4:
        sResult += "Four";
        break;
    case 5:
        sResult += "Five";
        break;
    case 6:
        sResult += "Six";
        break;
    case 7:
        sResult += "Seven";
        break;
    case 8:
        sResult += "Eight";
        break;
    case 9:
        sResult += "Nine";
        break;

}
Console.WriteLine(sResult);





Console.ReadLine();