public static class LineUp
{
    public static string Output(string name, int number, string number_ending)
    {
        return $"{name}, you are the {number}{number_ending} customer we serve today. Thank you!";
    }
    public static string Format(string name, int number)
    {
        if (number == 11 || number == 12 || number == 13 || number == 112)
        {
            return Output(name, number, "th");
        }
        else if (number % 10 == 1)
        {
            return Output(name, number, "st");
        }
        else if (number % 10 == 2)
        {
            return Output(name, number, "nd");
        }
        else if (number % 10 == 3)
        {
            return Output(name, number, "rd");   
        }
        return Output(name, number, "th");
    }
}
