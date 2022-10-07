using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public Animation door;

    public GameObject enemy;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.E))
        {
            door.Play();
            Vector3 position = new Vector3(-35.72f, 1, -123.99f);
            GameObject newEnemy = Instantiate(enemy, new Vector3(-35.72f, 1, -123.99f), new Quaternion(0,0,0,1));

            GameObject newEnemy2 = Instantiate(enemy, new Vector3(-36.72f, 1, -123.99f), new Quaternion(0,0,0,1));

            GameObject newEnemy3 = Instantiate(enemy, new Vector3(-34.72f, 1, -123.99f), new Quaternion(0,0,0,1));

            GameObject newEnemy4 = Instantiate(enemy, new Vector3(-33.72f, 1, -123.99f), new Quaternion(0,0,0,1));
        }
    }
}
