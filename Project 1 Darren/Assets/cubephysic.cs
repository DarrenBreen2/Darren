using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubephysic : MonoBehaviour
{
    Rigidbody ourRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ourRigidbody.AddExplosionForce(3,
                transform.position + Vector3.down + Vector3.back, 3);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            ourRigidbody.AddExplosionForce(3,
                transform.position + Vector3.down + Vector3.forward, 3);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
        
        
        planeScript planeHit = collision.gameObject.GetComponent<planeScript>();

        if (planeHit)
        {
            print("I hit a plane");
            planeHit.processHit();
        }
    }
}
