using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����TimeLine
/// </summary>
public class TimelinesManager : MonoBehaviour
{
    public GameObject ScanTimeline; //�״ν���ؿ�ʱ����ȫ���ؿ���timeline

    private void Awake()
    {
        if (GameManager.ThisSceneIsFirstLoad)
        {
            GameManager.TurnToScanMode();
            ScanTimeline.SetActive(true);
        }
    }
}
