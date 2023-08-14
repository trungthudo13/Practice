namespace Practice.Cqrs.Persistent.AbstractDatabaseConnection;

public class MongoDbContext
{
    private MongoDbContext? _instance;

    public MongoDbContext? Instance => _instance ??= new MongoDbContext();

    private MongoDbContext()
    {

    }
}