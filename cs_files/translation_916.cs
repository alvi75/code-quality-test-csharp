using System;
using System.Collections.Generic;

public class Translation916<T>
{
    public virtual CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = CreateNetworkInterfaceRequestMarshaller.Instance;
    options.ResponseUnmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;
    return Invoke<CreateNetworkInterfaceResponse>(request, options);
}
}