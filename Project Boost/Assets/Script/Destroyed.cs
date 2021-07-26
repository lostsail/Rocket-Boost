using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 响应机关的触发
/// </summary>
public class Destroyed : MonoBehaviour,IDestroy
{
    public void DestroyEvent()
    {
        Destroy(gameObject);
    }
}
