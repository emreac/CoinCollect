using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Rigidbody2D rb;
    float movementSpeed = 5f;

    PlayerSprite target;
    Vector2 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerSprite>();
        moveDirection = (target.transform.position - transform.position).normalized * movementSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
