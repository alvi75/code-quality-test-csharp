using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

#pragma warning disable all

public class Translation346<T>
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
    
    public BasicSessionCredentials(string accessKeyId, string accessKeySecret, string sessionToken, long roleSessionDurationSeconds){
    if (accessKeyId == null){
        throw new ArgumentOutOfRangeException("Access key ID cannot be null.");
    }
    if (accessKeySecret == null){
        throw new ArgumentOutOfRangeException("Access key secret cannot be null.");
    }
    if (sessionToken == null){
        throw new ArgumentOutOfRangeException("Session token cannot be null.");
    }
    if (roleSessionDurationSeconds < 900 || roleSessionDurationSeconds > 3600){
        throw new ArgumentOutOfRangeException("Role session duration must be between 15min and 1Hr, got " + roleSessionDurationSeconds + "s");
    }
    this.accessKeyId = accessKeyId;
    this.accessKeySecret = accessKeySecret;
    this.sessionToken = sessionToken;
    this.roleSessionDurationSeconds = roleSessionDurationSeconds;
}
}