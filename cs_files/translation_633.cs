using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation633<T>
{
    // Common stub fields that might be referenced in methods
    private int blockSize = 1024;
    private int upto = 0;
    private byte[] currentBlock = new byte[1024];
    private List<byte[]> blocks = new List<byte[]>();
    private List<int> blockEnd = new List<int>();
    private int field_1_vcenter = 0;
    private int BLOCK_SIZE = 1024;
    private int DEFAULT_SIZE = 16;
    
    public static long GenerationFromSegmentsFileName(string fileName){
    if (fileName.Equals(OLD_SEGMENTS_GEN, StringComparison.Ordinal)){
        throw new System.ArgumentException("\"" + OLD_SEGMENTS_GEN + "\" is not a valid segment file name since 4.0");
    }
    else if (fileName.Equals(IndexFileNames.SEGMENTS, StringComparison.Ordinal)){
        return -1;
    }
    else{
        Debug.Assert(!fileName.StartsWith(IndexFileNames.SEGMENTS, StringComparison.Ordinal));
        long gen = ParseLong(fileName, 0);
        if (gen < 0){
            throw new System.ArgumentException("Invalid segment file name '" + fileName + "' - must be a segment file name (without extension) in one of the following formats: " + IndexFileNames.SEGMENTS + ", " + IndexFileNames.SEGMENTS_GEN + ", " + IndexFileNames.DELTA + ")");
        }
        return gen;
    }
}
}