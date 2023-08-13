namespace BucketList_Assignment3.Models
{
    public class List
    {
        public int Id { get; set; }

        public string AdventureName { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool Completed { get; set; }
    }

}
