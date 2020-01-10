using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public int age;
    public string favoriteMovie { get; private set; }
    public GameObject spouse;

    public bool isMarried {
        get
        {
            return spouse != null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, my name is " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
