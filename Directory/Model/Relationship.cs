namespace Directory.Model
{
    public class Relationship
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public RelationshipType Relation { get; set; }
    }
}
