using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation377<T>
{
    // Common stub fields that might be referenced in methods
    private int blockSize = 1024;
    private int upto = 0;
    private byte[] currentBlock = new byte[1024];
    private List<byte[]> blocks = new List<byte[]>();
    private List<int> blockEnd = new List<int>();
    private int field_1_vcenter = 0;
    private int BLOCK_SIZE = 1024;
    private int DEFAULT_SIZE = 16;
    
    public virtual AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request){
    var options = new InvokeOptions();
    options.RequestMarshaller = AttachLoadBalancersRequestMarshaller.Instance;
    options.ResponseUnmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;
    return Invoke<AttachLoadBalancersResponse>(request, options);
}
}