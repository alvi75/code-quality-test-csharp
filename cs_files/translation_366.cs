using System;
using System.Collections.Generic;

public class Translation366<T>
{
    public void NotifyDeleteCell(ICell cell){
    _bookEvaluator.NotifyDeleteCell(new HSSFEvaluationCell(cell));
}
}