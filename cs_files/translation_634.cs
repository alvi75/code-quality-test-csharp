using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation634<T>
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
    
    public static NGit.TagCommand.TagOpt FromString(string str){
    if (str.Length != 0){
        str = str.ToLower();
    }
    foreach (TagOpt opt in _values){
        if (opt.Option.Equals(str, StringComparison.Ordinal)){
            return opt;
        }
    }
    throw new ArgumentException(MessageFormat.Format(JGitText.Get().invalidTagOption, str));
}
}