

using System.Data.SQLite;

public class SqliteDataService
{
    private string _databasePath;

    public SqliteDataService(string databasePath)
    {
        _databasePath = databasePath;
    }

    public SQLiteConnection GetDbConnection()
    {
        string connectionString = $"Data Source={_databasePath};";
        return new SQLiteConnection(connectionString);
    }
}