using System;
using System.Collections.Generic;

public class Translation688<T>
{
    public virtual CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
    options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;
    return Invoke<CreatePlayerSessionsResponse>(request, options);
}
}