using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject axe;
    public Rigidbody2D axeRb;
    private GameObject isAxe;
    private BoxCollider2D boxCollider2D;
    [SerializeField] private LayerMask groundLayerMask;

    public float speed;
    float input;

    public float jumpHeight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

    void Update()
    {
        isAxe = GameObject.FindGameObjectWithTag("Axe");
        if (isAxe == null)
        {
            Instantiate(axe, rb.position, Quaternion.identity);
        }

        if (Input.GetKeyDown("w") && IsGrounded())
        {
            rb.velocity = Vector2.up * jumpHeight;
        }
    }
    
    bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down * .1f, groundLayerMask);
        return raycastHit2D.collider != null;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
