using DataModel.Entities;
using DataModel.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.DataProviders.EFs.Base.Repos
{
    public class HistoryRep : IHistoryRep
    {
        public Task AddAsync(History history)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var history = await context.FindAsync(id);
            }
        }

        public IQueryable<History> GetHistories(bool isAdmin = false)
        {
            using (DatabaseContext context = new DatabaseContext()) 
            {
                return context.Histories.Where(x => x.IsAdmin == isAdmin);
            }
        }
    }
}
