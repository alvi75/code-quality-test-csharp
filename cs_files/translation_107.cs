using System;
using System.Collections.Generic;

public class Translation107<T>
{
    public virtual UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = UpdateDistributionRequestMarshaller.Instance;
    options.ResponseUnmarshaller = UpdateDistributionResponseUnmarshaller.Instance;
    return Invoke<UpdateDistributionResponse>(request, options);
}
}