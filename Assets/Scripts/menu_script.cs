using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{
    
    public void newButton()
    {
        SceneManager.LoadScene(1);
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
