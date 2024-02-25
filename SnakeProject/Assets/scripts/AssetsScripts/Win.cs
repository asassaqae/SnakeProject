using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] SceneAsset nextScene;
    void Start()
    {
        
    }
    void Update()
    {
        if (GameData.Score >= GetMaxScore())
        {
            GameData.Score = 0;
            SceneManager.LoadScene(nextScene.name);
        }
    }

    float GetMaxScore()
    {
        return GameData.applesRemaning + GameData.Score;
    }
}
