using System;
using System.Collections.Generic;

public class Translation934<T>
{
    public virtual bool isNamespaceAware(){
    return getFeature(org.xmlpull.v1.XmlPullParserClass.FEATURE_PROCESS_NAMESPACES);
}
}