static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id != null)
            return $"[{id}] - {name} - {(department ?? "owner").ToUpper()}";
        else if (department != null)
            return $"{name} - {department.ToUpper()}";
        return $"{name} - OWNER";
    }
}
