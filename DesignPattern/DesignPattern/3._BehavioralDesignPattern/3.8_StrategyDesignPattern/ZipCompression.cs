using DesignPattern.BehavioralDesignPattern.StrategyDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.StrategyDesignPattern
{
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
                 + ".zip' file is created");
        }
    }
}
