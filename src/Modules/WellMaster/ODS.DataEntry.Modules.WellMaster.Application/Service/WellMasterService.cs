using ODS.DataEntry.Modules.WellMaster.Data.WellMaster;
using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;

namespace ODS.DataEntry.Modules.WellMaster.Application.Service
{
    public class WellMasterService : IWellMasterService
    {
        private readonly IWellMasterRepository _wellMasterRepository;
        public WellMasterService(IWellMasterRepository wellMasterRepository)
        {
            _wellMasterRepository = wellMasterRepository;
        }
        public async Task<WellMasterEntity> GetWellMasterByIdAsync(int id)
        {
            return await _wellMasterRepository.GetWellMasterByIdAsync(id);
        }

        public async Task<IEnumerable<WellMasterEntity>> GetWellMastersAsync()
        {
            return await _wellMasterRepository.GetWellMastersAsync();
        }
    }
}
