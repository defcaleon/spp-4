namespace Business
{

    public class WriterOptions
    {
        public string Filename { get; }

        public string Content { get; }

        public WriterOptions(string filename, string content)
        {
            Filename = filename;
            Content = content;
        }
    }
}