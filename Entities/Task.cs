namespace BlazorCourseWebAssembly.Entities
{
    public class Task
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
