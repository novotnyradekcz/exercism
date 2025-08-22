using System;

enum AccountType
{
    Guest,
    User,
    Moderator
}

[Flags]
enum Permission : byte
{
    Read = 0b00000001,
    Write = 0b00000010,
    Delete = 0b00000100,
    All = 0b00000111,
    None = 0b00000000
}

static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType)
        {
            case AccountType.Guest:
                return (Permission)0b00000001;
            case AccountType.User:
                return (Permission)0b00000011;
            case AccountType.Moderator:
                return (Permission)0b00000111;
            default:
                return (Permission)0b00000000;
        }
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        return (current & check) == check;
    }
}
