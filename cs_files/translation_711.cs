using System;
using System.Collections.Generic;

public class Translation711<T>
{
    public virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
    options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;
    return Invoke<ListTemplatesResponse>(request, options);
}
}