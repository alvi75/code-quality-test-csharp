using System;
using System.Collections.Generic;

public class Translation596<T>
{
    public virtual CreateMatchmakingRuleSetResponse CreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
    options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;
    return Invoke<CreateMatchmakingRuleSetResponse>(request, options);
}
}