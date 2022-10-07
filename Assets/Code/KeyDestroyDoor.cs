using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDestroyDoor : MonoBehaviour
{
    public GameObject door;
    
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            print("This ran");
        Destroy(door);
        Destroy(gameObject);
        }
    }
}
