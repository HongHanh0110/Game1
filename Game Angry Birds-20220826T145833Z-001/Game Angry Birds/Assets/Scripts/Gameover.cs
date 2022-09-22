using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Gameover : MonoBehaviour
{
    public void ReLoad()
    {
        SceneManager.LoadScene("Level2");
    }

    public void playAgain()
    {
        SceneManager.LoadScene("Level1");
    }
}
