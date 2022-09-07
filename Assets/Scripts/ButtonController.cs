using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{   
    public void OnClickLoadScene()
    {
        SceneManager.LoadScene(1);
    }  
    public void OnClickBackScene()
    {
        SceneManager.LoadScene(0);
    } 
    public void QuitGame()
    {
        Application.Quit();
    }
}
