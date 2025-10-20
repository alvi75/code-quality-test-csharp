using System;
using System.Collections.Generic;

public class Translation600<T>
{
    public virtual CreateDomainEntryResponse CreateDomainEntry(CreateDomainEntryRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = CreateDomainEntryRequestMarshaller.Instance;
    options.ResponseUnmarshaller = CreateDomainEntryResponseUnmarshaller.Instance;
    return Invoke<CreateDomainEntryResponse>(request, options);
}
}