using System;
using System.Collections.Generic;

public class Translation788<T>
{
    public virtual DeleteTableResponse DeleteTable(string tableName){
    var request = new DeleteTableRequest();
    request.TableName = tableName;
    return DeleteTable(request);
}
}