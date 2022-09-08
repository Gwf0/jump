using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class About : MonoBehaviour
{
    public GameObject AboutMenu;
    void Start()
    {
        AboutMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenAboutMenu()
    {
        AboutMenu.SetActive(true);
    }

    public void CloseAboutMenu()
    {
        AboutMenu.SetActive(false);
    }
}
