using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    public float Speed;
    //private float move;
    private Vector2 moveInput;
    
    public float JumpForce;
    public bool Isjump;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*move = Input.GetAxis("Horizontal"); 
        rb2d.linearVelocity = new Vector2(move * Speed, rb2d.linearVelocity.y);*/
        
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb2d.AddForce(moveInput * Speed);
        
        //jump
        if (Input.GetButtonDown("Jump") && !Isjump)
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, JumpForce));
            Debug.Log("Jump");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Isjump = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Isjump = true;
        }
    }
}
