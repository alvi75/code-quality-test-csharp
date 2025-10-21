using System;
using System.Collections.Generic;

public class Translation388<T>
{
    public virtual DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DeleteHsmConfigurationRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;
    return Invoke<DeleteHsmConfigurationResponse>(request, options);
}
}