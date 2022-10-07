using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform playerTrans;

    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTrans.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTrans.position + offset;
    }
}
