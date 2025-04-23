namespace TO_DO_or_else.Domain
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int ObjectiveId { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Objective Objective { get; set; }
    }

}
