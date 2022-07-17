using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChamber : MonoBehaviour
{
    public GameObject littleChamber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CreateChamber();
        }
    }
    void CreateChamber()
    {
        Instantiate(littleChamber, transform.position, transform.rotation);
    }
}
