namespace Day9LabADOConnection
{
    public interface IFileStream
    {
        void ReadFile(string filename);
        void WriteFile(string filename);
    }
}
