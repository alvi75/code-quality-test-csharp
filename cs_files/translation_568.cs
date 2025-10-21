using System;
using System.Collections.Generic;

public class Translation568<T>
{
    public virtual ListAppliedSchemaArnsResponse ListAppliedSchemaArns(ListAppliedSchemaArnsRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = ListAppliedSchemaArnsRequestMarshaller.Instance;
    options.ResponseUnmarshaller = ListAppliedSchemaArnsResponseUnmarshaller.Instance;
    return Invoke<ListAppliedSchemaArnsResponse>(request, options);
}
}