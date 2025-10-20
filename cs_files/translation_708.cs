using System;
using System.Collections.Generic;

public class Translation708<T>
{
    public virtual AttachStaticIpResponse AttachStaticIp(AttachStaticIpRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = AttachStaticIpRequestMarshaller.Instance;
    options.ResponseUnmarshaller = AttachStaticIpResponseUnmarshaller.Instance;
    return Invoke<AttachStaticIpResponse>(request, options);
}
}