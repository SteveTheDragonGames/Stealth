using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
 private static UIManager _instance;
 public static UIManager Instance
 {
     get
     {
        if (_instance == null)
        {
            Debug.LogError("UIManager is null");
        }
        return _instance;    
     }
 }

 void Awake()
 {
     _instance = this;
 }

 //restart function

 public void Restart()
 {
     SceneManager.LoadScene("Game");
 }

 //quit function

 public void Quit()
 {
     Application.Quit();
 }
}