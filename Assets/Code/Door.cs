using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public int doorCode = 0;
    public bool locked = false;

    public string levelToLoad = "Level1";

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            if(!locked)
            {
                SceneManager.LoadScene("levelToLoad");

            }
            else if(PublicVars.hasKey[doorCode]) 
                {
                    PublicVars.hasKey[doorCode] = false;
                    SceneManager.LoadScene("levelToLoad");
                }
            }
        }
    }

}
