using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// 在首次进入关卡时显示关卡名
/// </summary>
public class StageText : MonoBehaviour
{
    Text text;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int levelID = currentScene.buildIndex;
        string levelName = currentScene.name;
        text = gameObject.GetComponent<Text>();
        text.text = $"1-{levelID+1} {levelName}";
    }
}
