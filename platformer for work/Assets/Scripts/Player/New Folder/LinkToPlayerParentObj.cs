using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkToPlayerParentObj : MonoBehaviour
{
    public static LinkToPlayerParentObj singltone;
    protected LinkToPlayerParentObj() { }
    
    private void Awake()
    {
        singltone = this;
    }

    public static LinkToPlayerParentObj getSingltone()
    {
        return singltone;
    }
}

