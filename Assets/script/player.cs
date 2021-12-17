using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public Rigidbody2D Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        Player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * playerSpeed;
    }
}

