using Xunit;

public class SecurityTests
{
    [Fact]
    public void InvalidUsername_ShouldFailValidation()
    {
        bool result = InputValidator.IsValidUsername("!baduser");

        Assert.False(result);
    }

    [Fact]
    public void ValidUsername_ShouldPassValidation()
    {
        bool result = InputValidator.IsValidUsername("user123");

        Assert.True(result);
    }

    [Fact]
    public void RBAC_Admin_ShouldAccessAdminPanel()
    {
        bool result = AuthorizationService.CanAccessAdmin(Role.Admin);

        Assert.True(result);
    }

    [Fact]
    public void RBAC_User_ShouldNotAccessAdminPanel()
    {
        bool result = AuthorizationService.CanAccessAdmin(Role.User);

        Assert.False(result);
    }
}