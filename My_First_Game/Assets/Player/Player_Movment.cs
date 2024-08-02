using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{

    public float MoveSpeed;
    float SpeedX, SpeedY;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SpeedX = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        SpeedY = Input.GetAxisRaw("Vertical") * MoveSpeed;
        rb.velocity = new UnityEngine.Vector2(SpeedX, SpeedY);
    }
}
