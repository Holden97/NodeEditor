using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[System.Serializable]
public class Adder : Node
{
    [Input] public float a;
    [Input] public float b;
    [Output] public float result;

    // GetValue should be overridden to return a value for any specified output port
    public override object GetValue(NodePort port)
    {
        return a + b;
    }
}