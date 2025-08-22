using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null)
        {
            if (department == null)
                return $"{name} - OWNER";
            return $"{name} - {department.ToUpper()}";
        }
        if (department == null)
            return $"[{id}] - {name} - OWNER";
        return $"[{id}] - {name} - {department.ToUpper()}";
    }
}
