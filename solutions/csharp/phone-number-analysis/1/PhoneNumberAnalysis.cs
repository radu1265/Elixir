public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        return (phoneNumber.Substring(0,3) == "212", phoneNumber.Substring(phoneNumber.IndexOf("-") + 1).StartsWith("555"), phoneNumber.Substring(phoneNumber.Length - 4));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
