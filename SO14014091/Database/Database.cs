using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SO14014091.Database
{
    public class Database : IDatabase
    {
        /// <summary>
        /// Register a product vote
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="productid"></param>
        /// <param name="vote"></param>
        public bool RegisterProductVote(int userId, int productid, int vote)
        {
            // access your database here and update/insert the vote

            return true;
        }
    }
}
