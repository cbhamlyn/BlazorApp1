namespace BlazorApp1
{
    public class TodoItem
    {
        // Get or Set the Title of the Todo item (the "?" in "string?" means the string can be null!)
        public string? Title { get; set; }
        // Get or Set the IsDone flag for this specific Todo item.
        public bool IsDone { get; set; } = false;
    }
}
