using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void respawn()
        {
            Instantiate(player, transform.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.R))
        {
            respawn();
        }
    }
}
