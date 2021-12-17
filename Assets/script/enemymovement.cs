using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public Rigidbody2D enemy;
    public float enemyspeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveenemy();
    }
    public void moveenemy()
    {
        enemy.velocity = new Vector2(1, 0) * Random.Range(-1, 1);
        enemy.velocity = new Vector2(0, 1) * Random.Range(0, -1);
    }
}
