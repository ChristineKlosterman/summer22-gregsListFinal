using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using gregslistFinnaly.Models;

namespace gregslistFinnaly.Repositories
{
    public class HousesRepository
    {
        private readonly IDbConnection _db;

        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<House> GetAll()
        {
            string sql = @"
            SELECT * FROM houses;
            ";
            List<House> houses = _db.Query<House>(sql).ToList();
            return houses;
        }
    }
}