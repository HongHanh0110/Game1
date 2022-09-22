using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    Enemy[] Enemies;// co nhieu lon
                    // Start is called before the first frame update

    void OnEnable()
    {
        Enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("pigs") == null)
        {
            SceneManager.LoadScene("win");
        }
        if (GameObject.FindGameObjectWithTag("birds") == null && GameObject.FindGameObjectWithTag("pigs") != null)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}






