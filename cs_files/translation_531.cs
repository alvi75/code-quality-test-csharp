using System;
using System.Collections.Generic;

public class Translation531<T>
{
    public virtual void SetNoChildReport(){
    letChildReport = false;
    foreach (PerfTask task in tasks){
        if (task is TaskSequence){
            ((TaskSequence)task).SetNoChildReport();
        }
    }
}
}