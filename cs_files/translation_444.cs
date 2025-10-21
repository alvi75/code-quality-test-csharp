using System;
using System.Collections.Generic;

public class Translation444<T>
{
    public virtual AssociateMemberAccountResponse AssociateMemberAccount(AssociateMemberAccountRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = AssociateMemberAccountRequestMarshaller.Instance;
    options.ResponseUnmarshaller = AssociateMemberAccountResponseUnmarshaller.Instance;
    return Invoke<AssociateMemberAccountResponse>(request, options);
}
}