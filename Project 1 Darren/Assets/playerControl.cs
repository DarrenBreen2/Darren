using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            Destroy(this.gameObject);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        
        wallScript wallHit = collision.gameObject.GetComponent<wallScript>();
        endGoal goalHit = collision.gameObject.GetComponent<endGoal>();
       
        if (wallHit)
        {
            print("I lose");
            Destroy(this.gameObject);
            wallHit.contact();
        }

        if (goalHit)
        {
            print("I Win");
            Destroy(this.gameObject);
            screenChange.Instance.sceneTomoveTo();
            screen2to3.Instance.sceneTomoveTo();
        }
    }
}
    
