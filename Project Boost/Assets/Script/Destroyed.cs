using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��Ӧ���صĴ���
/// </summary>
public class Destroyed : MonoBehaviour,IDestroy
{
    public void DestroyEvent()
    {
        Destroy(gameObject);
    }
}
