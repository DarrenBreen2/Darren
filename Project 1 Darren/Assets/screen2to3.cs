using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screen2to3 : MonoBehaviour
{

    public static screen2to3 Instance;


    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneTomoveTo()
    {
        SceneManager.LoadScene("GameProject3");
    }
}
