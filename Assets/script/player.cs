using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed = 8.0f;
    public Rigidbody2D Player;
    public int life = 3;
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
    void OnColliderHit(Collider collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            life --;
        }
    }
}

