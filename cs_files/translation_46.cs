using System;
using System.Collections.Generic;

public class Translation46<T>
{
    public virtual void SetProgressMonitor(ProgressMonitor pm){
    this.pm = (pm == null) ? NullProgressMonitor.INSTANCE : pm;
}
}