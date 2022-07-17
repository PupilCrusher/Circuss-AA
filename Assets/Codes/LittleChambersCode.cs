using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleChambersCode : MonoBehaviour
{
    Rigidbody2D physic;
    public float speed;
    bool movementControl = false;
    void Start()
    {
        physic = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    { if (!movementControl)
        {
            physic.MovePosition(physic.position + Vector2.up * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="chambertag")
        {
            transform.SetParent(col.transform);
            movementControl = true;
        }
    }
}
