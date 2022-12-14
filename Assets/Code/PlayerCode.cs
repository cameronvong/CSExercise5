using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCode : MonoBehaviour
{
    int bulletForce = 500;
    NavMeshAgent _agent;
    Camera mainCam;

    public GameObject Bullet;

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

                GameObject newBullet = Instantiate(Bullet, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
            }
        }
    }

     private void OnTriggerEnter(Collider other) 
     {
        
     }
}