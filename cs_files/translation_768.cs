using System;
using System.Collections.Generic;

public class Translation768<T>
{
    public virtual ActivateUserResponse ActivateUser(ActivateUserRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = ActivateUserRequestMarshaller.Instance;
    options.ResponseUnmarshaller = ActivateUserResponseUnmarshaller.Instance;
    return Invoke<ActivateUserResponse>(request, options);
}
}