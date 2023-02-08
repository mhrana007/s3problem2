
namespace GlobalEntity
{
    public class ReadingModel
    {
        public Int64 Id { get; set; }
        public int BuildingId { get; set; }
        public int ObjectId { get; set; }
        public int DataFieldId { get; set; }
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
