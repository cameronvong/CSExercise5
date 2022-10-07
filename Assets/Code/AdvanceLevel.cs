using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceLevel : MonoBehaviour
{
    public string level;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene(level);
        }
    }
}
