namespace ODS.DataEntry.Modules.WellMaster.Domain.WellMaster
{
    public interface IWellMasterService
    {
        Task<WellMasterEntity> GetWellMasterByIdAsync(int id);
        Task<IEnumerable<WellMasterEntity>> GetWellMastersAsync();
    }
}
