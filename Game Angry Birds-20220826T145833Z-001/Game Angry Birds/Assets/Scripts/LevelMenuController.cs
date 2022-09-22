using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenuController : MonoBehaviour
{
    [System.Obsolete]
    public void PlayGame()
    {
        Application.LoadLevel("GamePlay");
    }

    [System.Obsolete]
    public void BackToMenu()
    {
        Application.LoadLevel("MainMenu");
    }

}
