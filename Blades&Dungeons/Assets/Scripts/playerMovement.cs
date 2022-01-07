using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    bool faceRight = true;

    [SerializeField] float jumpForce;
    [SerializeField] float groundDistance;
    [SerializeField] bool isGrounded;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        float hor = Input.GetAxis("Horizontal");
                rb.velocity=new Vector2(hor*speed, rb.velocity.y);

        if(faceRight && hor<0 || !faceRight && hor > 0)
        {
            faceRight = !faceRight;
            transform.Rotate(0,180,0);
        }
    }
}