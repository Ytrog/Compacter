namespace Compacter
{
    internal class FolderManager
    {
        public required string Path { get; init; }
        private DirectoryInfo? _folder;
        private const string _pattern = "*.*";
        private List<FileItem>? _fileItems;
        public bool Initialized { get; private set; } = false;
        public bool Analyzed { get; private set; }
        internal List<FileItem>? FileItems { get => _fileItems; set => _fileItems = value; }

        public FolderManager()
        {

        }

        public void Init()
        {
            if (!string.IsNullOrWhiteSpace(Path) && System.IO.Path.Exists(Path))
            {
                _folder = new DirectoryInfo(Path);

                var files = _folder.EnumerateFiles(_pattern, new EnumerationOptions { RecurseSubdirectories = true, MaxRecursionDepth = 4 });
                FileItems = files.Select(f => new FileItem { Path = f.FullName }).ToList();

                Initialized = true;
            }
            else { throw new InvalidOperationException(); }
        }

        internal void Analyze(bool parallel = false)
        {
            Analyzed = false;
            if (!Initialized || FileItems == null)
            {
                throw new InvalidOperationException("Not initialized");
            }

            if (parallel)
            {
                Parallel.ForEach(FileItems, fi => fi.Analyze());
            }
            else
            {
                foreach (var fi in FileItems)
                {
                    fi.Analyze();
                } 
            }
            Analyzed = true; // this is used for checking if compress button should be enabled
        }
    }
}
