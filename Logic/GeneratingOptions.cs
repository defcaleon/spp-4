namespace Business
{
    public class GeneratingOptions
    {
        public int MaxRead { get; set; } = 5;

        public int MaxGenerate { get; set; } = 5;

        public int MaxWrite { get; set; } = 5;

        public string SourceDirectory { get; set; }

        public string DestinationDirectory { get; set; }
    }

}