using System;
using System.Collections.Generic;

public class Translation164<T>
{
    public virtual DeleteAlarmResponse DeleteAlarm(DeleteAlarmRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DeleteAlarmRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DeleteAlarmResponseUnmarshaller.Instance;
    return Invoke<DeleteAlarmResponse>(request, options);
}
}