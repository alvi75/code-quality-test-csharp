using System;
using System.Collections.Generic;

public class Translation315<T>
{
    public virtual DeleteAccessControlRuleResponse DeleteAccessControlRule(DeleteAccessControlRuleRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DeleteAccessControlRuleRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DeleteAccessControlRuleResponseUnmarshaller.Instance;
    return Invoke<DeleteAccessControlRuleResponse>(request, options);
}
}