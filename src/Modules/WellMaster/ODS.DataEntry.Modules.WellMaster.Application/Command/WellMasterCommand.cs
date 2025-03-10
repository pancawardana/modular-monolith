using AutoMapper;
using MediatR;
using ODS.DataEntry.Modules.WellMaster.Application.DTO;
using ODS.DataEntry.Modules.WellMaster.Data.WellMaster;

namespace ODS.DataEntry.Modules.WellMaster.Application.Command
{
    public class GetWellMasterCommand : IRequest<IEnumerable<WellMasterDto>>
    {
    }

    public class GetWellMasterCommandHandler : IRequestHandler<GetWellMasterCommand, IEnumerable<WellMasterDto>>
    {
        private readonly IWellMasterRepository _wellMasterRepository;
        private readonly IMapper _mapper;
        public GetWellMasterCommandHandler(IWellMasterRepository wellMasterRepository, IMapper mapper)
        {
            _wellMasterRepository = wellMasterRepository;
            _mapper = mapper;

        }

        public async Task<IEnumerable<WellMasterDto>> Handle(GetWellMasterCommand request, CancellationToken cancellationToken)
        {
            var items = await _wellMasterRepository.GetWellMastersAsync();

            var wellMasters = _mapper.Map<IEnumerable<WellMasterDto>>(items);
            return wellMasters;
        }
    }
}
