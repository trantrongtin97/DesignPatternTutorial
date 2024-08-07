﻿using DesignPattern.BehavioralDesignPattern.StrategyDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.StrategyDesignPattern
{
    public class CompressionContext
    {
        private ICompression Compression;
        public CompressionContext(ICompression Compression)
        {
            this.Compression = Compression;
        }
        public void SetStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }
        public void CreateArchive(string compressedArchiveFileName)
        {
            Compression.CompressFolder(compressedArchiveFileName);
        }
    }
}
