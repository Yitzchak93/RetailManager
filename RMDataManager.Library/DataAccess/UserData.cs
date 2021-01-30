using RMDataManager.Library.Models;
using System.Collections.Generic;

//using RMDataManager.Library.Models;

namespace RMDataManager.Library.DataAccess
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _sql;

        public UserData(ISqlDataAccess sql)
        {
            _sql = sql;
        }
        public List<UserModel> GetUserById(string Id)
        {
            var output = _sql.LoadData<UserModel, dynamic>("spUserLookup", new { Id }, "RMData");
            return output;
        }
    }
}
