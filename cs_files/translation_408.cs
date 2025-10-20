using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation408<T>
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
    
    public static double CalcDistanceFromErrPct(Shape shape, double distErrPct, SpatialContext ctx){
    if (distErrPct < 0 || distErrPct > 0.5){
        throw new ArgumentException("distErrPct " + distErrPct + " must be between [0 to 0.5]");
    }
    var bbox = shape.BoundingBox;
    var ctr = bbox.Center;
    double distErr = CalcDistance(ctr, bbox.MinX, bbox.MaxX, bbox.MinY, bbox.MaxY, distErrPct, ctx);
    return distErr;
}
}