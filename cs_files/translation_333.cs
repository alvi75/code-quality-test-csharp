using System;
using System.Collections.Generic;

public class Translation333<T>
{
    public override float DocScore(int docId, string field, int numPayloadsSeen, float payloadScore){
    return numPayloadsSeen > 0 ? (payloadScore / numPayloadsSeen) : 1;
}
}