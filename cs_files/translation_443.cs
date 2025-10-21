using System;
using System.Collections.Generic;

public class Translation443<T>
{
    public virtual CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = CreateOptionGroupRequestMarshaller.Instance;
    options.ResponseUnmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;
    return Invoke<CreateOptionGroupResponse>(request, options);
}
}