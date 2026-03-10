public static class AuthorizationService
{
    public static bool CanAccessAdmin(Role role)
    {
        return role == Role.Admin;
    }

    public static bool CanAccessUser(Role role)
    {
        return role == Role.Admin || role == Role.User;
    }
}