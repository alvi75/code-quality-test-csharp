using System;
using System.Collections.Generic;

public class Translation255<T>
{
    public virtual ListBonusPaymentsResponse ListBonusPayments(ListBonusPaymentsRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = ListBonusPaymentsRequestMarshaller.Instance;
    options.ResponseUnmarshaller = ListBonusPaymentsResponseUnmarshaller.Instance;
    return Invoke<ListBonusPaymentsResponse>(request, options);
}
}