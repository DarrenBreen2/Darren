using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screen4toend : MonoBehaviour
{

    public static screen4toend Instance;


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
