using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackOrChoose : MonoBehaviour
{
   
    public void Level1()
    {
        Application.LoadLevel("Level1");
    }
    public void Level2()
    {
        Application.LoadLevel("Level2");
    }

    public void Level3()
    {
        Application.LoadLevel("InforGame");
    }
    public void BackToMenu()
    {
        Application.LoadLevel("InforGame");
    }
}
