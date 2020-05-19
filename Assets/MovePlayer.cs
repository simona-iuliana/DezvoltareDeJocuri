using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    public Transform ground;
    public bool grounded;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private Rigidbody2D myrigidbody2D;

    public Checkpoint check;
    private string back = "Title Menu";
	// Use this for initialization
	void Start () {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        check = FindObjectOfType<Checkpoint>();
	}
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(ground.position, groundCheckRadius, whatIsGround);
    }
	// Update is called once per frame
	void Update () {

	 GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

     if (Input.GetKeyDown(KeyCode.Space) && grounded) 
        {
            myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, jumpHeight); 
        }
     if (Input.GetKeyDown(KeyCode.Escape))
     {
         Application.LoadLevel(back); 
     }
    }

    public void Die()
    {
        Destroy(gameObject);
        check.Initate();
    }
}
