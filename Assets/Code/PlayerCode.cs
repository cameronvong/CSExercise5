using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCode : MonoBehaviour
{
    NavMeshAgent _agent;
    Camera mainCam;

    void Start() 
    {
        _agent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
    }

    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200))
            {
                _agent.SetDestination(hit.point);
            }
        }
        else if (Input.GetMouseButtonDown(1)) 
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200))
            {
                transform.LookAt(hit.point);

                //GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                // newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce)
            }
        }
    }

     private void OnTriggerEnter(Collider other) 
     {
        
        for (int i = 0; i < PublicVars.hasKey.Length; i++)
        {
            if (other.gameObject.CompareTag("Key" + i))
            {
                Destroy(other.gameObject);
                PublicVars.hasKey[i] = true;
            }
        }
     }
}