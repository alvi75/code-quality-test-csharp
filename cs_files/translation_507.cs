using System;
using System.Collections.Generic;

public class Translation507<T>
{
    public virtual DeleteMailboxPermissionsResponse DeleteMailboxPermissions(DeleteMailboxPermissionsRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DeleteMailboxPermissionsRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DeleteMailboxPermissionsResponseUnmarshaller.Instance;
    return Invoke<DeleteMailboxPermissionsResponse>(request, options);
}
}