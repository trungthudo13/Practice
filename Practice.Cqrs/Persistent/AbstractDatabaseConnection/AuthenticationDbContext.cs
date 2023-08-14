using System.Data.Entity;

namespace Practice.Cqrs.Persistent.AbstractDatabaseConnection;

public class AuthenticationDbContext : DbContext
{
    private static AuthenticationDbContext? _instance;
    public static AuthenticationDbContext Instance => _instance ??= new AuthenticationDbContext();

    private AuthenticationDbContext() : base()
    {

    }
}