using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    public int index;
    public string levelName;


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Player"))
        {
            //Loading level with build index
            SceneManager.LoadScene(1);

            //Loading level with scene name
            SceneManager.LoadScene(levelName);

        }

    }
}
