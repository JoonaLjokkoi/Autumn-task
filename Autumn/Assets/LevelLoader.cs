using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(2);
    }
    
    public string scene;

    public void LoadLevel() {
        SceneManager.LoadScene(1);
    }
}