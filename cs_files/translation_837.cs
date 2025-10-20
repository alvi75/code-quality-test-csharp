using System;
using System.Collections.Generic;

public class Translation837<T>
{
    public virtual DisassociateConnectionFromLagResponse DisassociateConnectionFromLag(DisassociateConnectionFromLagRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = DisassociateConnectionFromLagRequestMarshaller.Instance;
    options.ResponseUnmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;
    return Invoke<DisassociateConnectionFromLagResponse>(request, options);
}
}