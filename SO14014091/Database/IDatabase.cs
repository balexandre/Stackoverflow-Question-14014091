using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SO14014091.Database
{
    public interface IDatabase
    {
        bool RegisterProductVote(int userId, int productid, int vote);
    }
}