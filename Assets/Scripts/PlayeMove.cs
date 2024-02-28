using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMove : MonoBehaviour
{
    public Vector3 newPosition = new Vector3 (50 , 5 , 0);
    public float movimentSpeed = 5 ; 
    private float inputHorizontal;
    public bool jump = false ; 
    public Rigidbody2D rbody; 
    public float jumpForce = 5 
    public GroundSensor sensor ; 
    public SpritRenderer render; 
    
    void Awake ()
    {
        rBody = GetConponent Rigidbody2D;
        source  =Getconponent;


    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
 inputHorizontal=input.GetAxis("horizontal"); 
 if(input.GetButtonDon("jump")&& sensor . isGrounded = true)
 {
    rbody.adforce( new vector2(0,1) * jumpForce , ForceMode2D.impulse) ;
    anim.SetBool("IsJumping" . true);
    
 }
    if(inputHorizontal);
    {
        render.flipx = true ;
        anim.SetBool("isRunning" , true );
    }

else 
{
    rBody.velocity = new Vector2(inputHorizontal * rbody . velocity . y);
}
    }
}
