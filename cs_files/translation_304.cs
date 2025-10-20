using System;
using System.Collections.Generic;

public class Translation304<T>
{
    public virtual PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
    options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;
    return Invoke<PromoteReadReplicaDBClusterResponse>(request, options);
}
}