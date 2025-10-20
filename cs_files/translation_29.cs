using System;
using System.Collections.Generic;

public class Translation29<T>
{
    public HSSFPolygon CreatePolygon(HSSFChildAnchor anchor){
    HSSFPolygon shape = new HSSFPolygon(this, anchor);
    shape.Parent = this;
    shape.Anchor = anchor;
    shapes.Add(shape);
    OnCreate(shape);
    return shape;
}
}