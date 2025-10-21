using System;
using System.Collections.Generic;

public class Translation10<T>
{
    public virtual ListIngestionsResponse ListIngestions(ListIngestionsRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = ListIngestionsRequestMarshaller.Instance;
    options.ResponseUnmarshaller = ListIngestionsResponseUnmarshaller.Instance;
    return Invoke<ListIngestionsResponse>(request, options);
}
}