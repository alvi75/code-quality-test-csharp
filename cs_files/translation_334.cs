using System;
using System.Collections.Generic;

public class Translation334<T>
{
    public override ICollection<IParseTree> Evaluate(IParseTree t){
    return Trees.FindAllRuleNodes(t, ruleIndex);
}
}