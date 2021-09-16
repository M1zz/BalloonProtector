using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeObstacle", 0.0f, 0.5f);   
    }

    void makeObstacle() 
    {
        Instantiate(obstacle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
