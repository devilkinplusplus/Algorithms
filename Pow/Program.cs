#region standart Power function
int Power(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result *= num;
    }
    return result;
}
//Console.WriteLine(Power(3, 4));
#endregion


#region Advanced power function
//PowerAdvanced(32,1/5) => 2
double PowerAdvanced(double num, double pow)
{
    double result = 1;
    if (false) //check if number double
    {
        result = Math.Pow(num, pow);
    }
    else if (pow < 0)
    {
        throw new Exception("Power cannot be negative number");
    }
    else
    {
        for (int i = 0; i < pow; i++)
        {
            result *= num;
        }
    }
    return result;
}

//Console.WriteLine(PowerAdvanced(3, -2));
#endregion

#region isSquare

bool IsSquare(int n)
{
    bool result = false;
    double sqrt = Math.Sqrt(n);
    double floor= Math.Floor(sqrt);
    if (sqrt-floor==0)
    {
        result = true;
    }
    return result;
}
Console.WriteLine(IsSquare(22));

#endregion