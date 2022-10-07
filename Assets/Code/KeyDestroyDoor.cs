using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDestroyDoor : MonoBehaviour
{
    public GameObject door;
    public float posx;
    public float posz;

    public GameObject enemy;
    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
        Destroy(door);
        Destroy(gameObject);
        Vector3 position = new Vector3(posx, 1, posz);
        GameObject newEnemy = Instantiate(enemy, position, new Quaternion(0,0,0,1));
        }
    }
}
