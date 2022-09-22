using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//level1
public class Level : MonoBehaviour
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
        if (GameObject.FindGameObjectWithTag("AA") == null)
        {
            SceneManager.LoadScene("Level2");
        }
        if (GameObject.FindGameObjectWithTag("Bird") == null && GameObject.FindGameObjectWithTag("AA") != null)
        {
            SceneManager.LoadScene("Over1");
        }
    }

}





