using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOVA
{
    public static class DBConnect
    {
        public static readonly NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=SOVAAPI; Password=rawdata; Database=stackoverflow");
    }
}
