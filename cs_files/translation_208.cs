using System;
using System.Collections.Generic;

public class Translation208<T>
{
    public override Object Clone(){
    MergeScheduler other = new MergeScheduler();
    other.m_scheduler = m_scheduler;
    return other;
}
}