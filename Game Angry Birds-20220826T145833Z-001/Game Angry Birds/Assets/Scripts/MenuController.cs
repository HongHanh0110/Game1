using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("MainMenu");
    }

 
    public void GoToPersonanlInfor()
    {
        Application.LoadLevel("PersonanlInfor");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("InforGame");
    }
}



