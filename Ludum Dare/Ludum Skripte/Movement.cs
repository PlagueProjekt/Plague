using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movement : MonoBehaviour
{

    public float xspeed, yspeed, distance, direction, deccel, decceldef;
    public GameObject ground, player;
    private Rigidbody2D rb;
    public float addspeed;
    static public float impactspeed;

    public float maxSpeed;
    public float JumpHeight;
    public float curJumpTarget;
    [Range(0.0f, 1.0f)]public float convergencefactor,defaultspeed;
    [Range(0.0f, 1.0f)] public float acceleration ;
    [Range(0.0f, 1.0f)] public float drag;
    [Range(0.0f, 1.0f)] public float jumpInsensity;
    bool onGround = true;
    public bool isJumping = false;
    float curSpeed = 0f;
        
    

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(xspeed, yspeed, 0); //Starte mit positiv Geschwindigkeit (rechts)
        //Time.fixedDeltaTime = 0.001f;
        distance = 0;
        direction = 1f;
        defaultspeed = 0.5f;
        convergencefactor = 0.75f;
        decceldef = .9f;
        deccel = .9f;
    }

    void FixedUpdate()
    {
        float curJump=0.0f;

        if (Input.GetButton("Jump") && !isJumping)
        {
            curJumpTarget = transform.position.y + JumpHeight;
            isJumping = true;
        }

        if (isJumping)
        {
            curJump = (curJumpTarget - transform.position.y) * jumpInsensity;
        }
        if (transform.position.y+2f >= curJumpTarget)
        {
            isJumping = false;
        }
      
        if (Input.GetAxis("Horizontal") == 0)
        {
            if (xspeed > 1f)
            {
                xspeed = xspeed * deccel;              // Invers exponentielle Funktion die den Player wieder abbremst
            }
            else
            {
                xspeed = 0;
                deccel = decceldef;
                addspeed = defaultspeed;
            }
           //direction = 1f;
        }
        else
        {
            addspeed = convergencefactor * addspeed;    // Konvergente Folge die dem beschränkten Wachstum ähnelt.
            xspeed = xspeed + addspeed;                 //
            if (Input.GetAxis("Horizontal") > 0)
            {
                direction = 1f;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                direction = -1f;
            }
        }
        transform.position=new Vector2(transform.position.x +direction*xspeed*Time.deltaTime,transform.position.y + curJump);
    }
}
