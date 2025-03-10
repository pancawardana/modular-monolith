using Microsoft.EntityFrameworkCore;
using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;

namespace ODS.DataEntry.Modules.WellMaster.Data.WellMaster
{
    public class WellMasterRepository : IWellMasterRepository
    {
        private readonly DbContext Db;

        public WellMasterRepository(DbContext db)
        {
            Db = db;
        }
        public async Task<WellMasterEntity?> GetWellMasterByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await Db.Set<WellMasterEntity>().FindAsync(id, cancellationToken);
        }

        public async Task<IEnumerable<WellMasterEntity>> GetWellMastersAsync()
        {
            return await Task.FromResult(Db.Set<WellMasterEntity>().AsEnumerable());
        }
    }
}
