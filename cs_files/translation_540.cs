using System;
using System.Collections.Generic;

public class Translation540<T>
{
    public virtual CreateScriptResponse CreateScript(CreateScriptRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
    options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;
    return Invoke<CreateScriptResponse>(request, options);
}
}