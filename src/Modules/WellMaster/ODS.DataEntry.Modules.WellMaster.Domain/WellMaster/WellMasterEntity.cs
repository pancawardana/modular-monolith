using ODS.DataEntry.Shared;

namespace ODS.DataEntry.Modules.WellMaster.Domain.WellMaster
{
    public class WellMasterEntity : BaseEntity
    {
        public string WellName { get; set; } = string.Empty;

        public string Api14 { get; set; } = string.Empty;

        public string? Appraisal { get; set; }

        public double? XCoordinate { get; set; }

        public double? YCoordinate { get; set; }

        public string? StopName { get; set; }

        public string? Status { get; set; }

        public string? Operated { get; set; }

        public DateTime? EcpWellInterestDate { get; set; }

        public double? WI { get; set; }

        public double? NRI { get; set; }

        public DateTime? FirstHydroCarbon { get; set; }

        public DateTime? FirstFlowBackDay { get; set; }

        public string? BaseWedge { get; set; }
    }
}
