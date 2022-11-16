using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataModel.Entities;

namespace DataModel.Repos
{
    public interface IHistoryRep
    {
        IQueryable<History> GetHistories(bool isAdmin = false);
        Task DeleteAsync(Guid id);
        Task AddAsync(History history);

    }
}
