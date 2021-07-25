using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    
    public void yes_btn()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex);
    }

    public void no_btn()
    {
        Application.Quit();
    }
}
