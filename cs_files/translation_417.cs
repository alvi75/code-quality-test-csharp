using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation417<T>
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
    
    public virtual IRuleBasedBreakIterator GetBreakIterator(int script){
    switch (script){
        case UScript.HANGUL: return GetHangulScriptBreakIterator();
        case UScript.HANGUL_YEH: return GetHangulScriptBreakIterator(YEH);
        case UScript.HANGUL_KANA: return GetHangulScriptBreakIterator(KANA);
        case UScript.HANGUL_LETTER: return GetHangulScriptBreakIterator(LETTER);
        case UScript.HANGUL_NUMBER: return GetHangulScriptBreakIterator(NUMBER);
        case UScript.HANGUL_YEH_NUMBER: return GetHangulScriptBreakIterator(YEH_NUMBER);
        default: return base.GetBreakIterator(script);
    }
}
}