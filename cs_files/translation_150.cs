using System;
using System.Collections.Generic;

public class Translation150<T>
{
    public virtual GetContactAttributesResponse GetContactAttributes(GetContactAttributesRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = GetContactAttributesRequestMarshaller.Instance;
    options.ResponseUnmarshaller = GetContactAttributesResponseUnmarshaller.Instance;
    return Invoke<GetContactAttributesResponse>(request, options);
}
}