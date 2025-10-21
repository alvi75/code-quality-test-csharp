using System;
using System.Collections.Generic;

public class Translation676<T>
{
    public void AddShape(HSSFShape shape){
    shape.Patriarch = this.Patriarch;
    shape.Parent = this;
    shapes.Add(shape);
}
}