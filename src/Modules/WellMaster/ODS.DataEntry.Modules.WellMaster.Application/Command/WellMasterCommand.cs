using AutoMapper;
using MediatR;
using ODS.DataEntry.Modules.WellMaster.Application.DTO;
using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;

namespace ODS.DataEntry.Modules.WellMaster.Application.Command
{
    public class GetWellMasterCommand : IRequest<IEnumerable<WellMasterDto>>
    {
    }

    public class GetWellMasterCommandHandler : IRequestHandler<GetWellMasterCommand, IEnumerable<WellMasterDto>>
    {
        private readonly IWellMasterService _wellMasterService;
        private readonly IMapper _mapper;
        public GetWellMasterCommandHandler(IWellMasterService wellMasterService, IMapper mapper)
        {
            _wellMasterService = wellMasterService;
            _mapper = mapper;

        }

        public async Task<IEnumerable<WellMasterDto>> Handle(GetWellMasterCommand request, CancellationToken cancellationToken)
        {
            var items = await _wellMasterService.GetWellMastersAsync();

            var wellMasters = _mapper.Map<IEnumerable<WellMasterDto>>(items);
            return wellMasters;
        }
    }
}
