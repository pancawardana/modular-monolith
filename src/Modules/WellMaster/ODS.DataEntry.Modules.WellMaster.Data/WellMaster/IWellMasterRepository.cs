using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;

namespace ODS.DataEntry.Modules.WellMaster.Data.WellMaster
{
    public interface IWellMasterRepository
    {
        Task<WellMasterEntity?> GetWellMasterByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<WellMasterEntity>> GetWellMastersAsync();
    }
}
