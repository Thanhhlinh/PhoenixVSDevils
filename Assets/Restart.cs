using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void LoadSceneMode(int scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1.0f;
    }

}
