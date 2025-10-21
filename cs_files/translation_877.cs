using System;
using System.Collections.Generic;

public class Translation877<T>
{
    public virtual ListImagesResponse ListImages(ListImagesRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = ListImagesRequestMarshaller.Instance;
    options.ResponseUnmarshaller = ListImagesResponseUnmarshaller.Instance;
    return Invoke<ListImagesResponse>(request, options);
}
}