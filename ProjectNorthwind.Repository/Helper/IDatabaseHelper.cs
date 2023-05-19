using System.Data;

namespace ProjectNorthwind.Repository.Helper
{
    public interface IDatabaseHelper
    {
        IDbConnection GetConnection();
    }
}