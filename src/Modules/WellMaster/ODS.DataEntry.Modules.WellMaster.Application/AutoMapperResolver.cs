namespace ODS.DataEntry.Modules.WellMaster.Application
{
    public static class AutoMapperResolver
    {
        public static string FullNameResolver(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            var splitName = name.Split("|");

            if (splitName.Length == 2)
            {
                return splitName[0];
            }

            return name;
        }

        public static TimeSpan? GetTime(DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }

            return new TimeSpan(dateTime.Value.Hour, dateTime.Value.Minute, dateTime.Value.Second);
        }
    }
}
