namespace Practice.Cqrs.Infrastructure.AbstractConnection;

public class ClientConnection
{
    private static ClientConnection? _instance;

    public static ClientConnection Instance => _instance ??= new ClientConnection();
}