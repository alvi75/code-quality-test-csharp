using System;
using System.Collections.Generic;

public class Translation279<T>
{
    public virtual StopCompilationJobResponse StopCompilationJob(StopCompilationJobRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = StopCompilationJobRequestMarshaller.Instance;
    options.ResponseUnmarshaller = StopCompilationJobResponseUnmarshaller.Instance;
    return Invoke<StopCompilationJobResponse>(request, options);
}
}