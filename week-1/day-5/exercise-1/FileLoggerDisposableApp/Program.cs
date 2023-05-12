namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
            using (var logger = new FileLogger("KB.txt"))
            {
                //logger.Log("Starting log");
                //logger.Log("This is a log entry");
                //logger.Log("Another log entry");
                //logger.Log("Ending log"); 
                logger.Log("I am Krunal...!");
                logger.Log("I want to be a Software Developer.....!!");
                logger.Dispose();
            }
            Console.WriteLine("Log entries written to file.");
        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter _streamWriter;
        private bool _disposed = false;

        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
            _streamWriter = new StreamWriter(filePath, append: true);
        }

        public void Dispose()
        {
            // Implement IDisposable pattern
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Log(string message)
        {
            // Write message to the file
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(FileLogger));
            }
            _streamWriter.WriteLine(DateTime.Now.ToString() + " " + message);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_streamWriter != null)
                    {
                        _streamWriter.Dispose();
                        _streamWriter = null;
                    }
                }
                _disposed = true;
            }
        }

        ~FileLogger()
        {
            Dispose(false);
        }
    }
}