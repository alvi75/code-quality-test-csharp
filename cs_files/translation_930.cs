using System;
using System.Collections.Generic;

public class Translation930<T>
{
    public virtual CreateVariableResponse CreateVariable(CreateVariableRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = CreateVariableRequestMarshaller.Instance;
    options.ResponseUnmarshaller = CreateVariableResponseUnmarshaller.Instance;
    return Invoke<CreateVariableResponse>(request, options);
}
}