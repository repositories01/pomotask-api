namespace pomotask.Models
{
    public class TaskModel
    {
        public TaskModel() { }
        public TaskModel(int id, string title)
        {
            this.id = id;
            this.title = title;

        }
        public int id { get; set; }
        public string title { get; set; }
    }
}