using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理TimeLine
/// </summary>
public class TimelinesManager : MonoBehaviour
{
    public GameObject ScanTimeline; //首次进入关卡时用于全览关卡的timeline

    private void Awake()
    {
        if (GameManager.ThisSceneIsFirstLoad)
        {
            GameManager.TurnToScanMode();
            ScanTimeline.SetActive(true);
        }
    }
}
