using System;
using System.Collections.Generic;

public class Translation646<T>
{
    public virtual void Recover(Parser recognizer, RecognitionException e){
    if (this.lexerActionExecutor != null){
        this.lexerActionExecutor.Recover(recognizer, e);
    }
    else{
        ErrorHandler.ReportError(this, e);
    }
}
}