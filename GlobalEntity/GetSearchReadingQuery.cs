namespace GlobalEntity
{
    public class GetSearchReadingQuery
    {
        public int BuildingId { get; set; }
        public int ObjectId { get; set; }
        public int DataFieldId { get; set; }
        public string StartDateRange { get; set; }
        public string EndDateRange { get; set; }
    }
}
