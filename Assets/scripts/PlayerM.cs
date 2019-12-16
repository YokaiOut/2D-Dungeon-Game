using UnityEngine;
using System.Collections;

public class PlayerM : MonoBehaviour
{
    public float speed = 10F;// this is the speed of the object that its assigned to 
    public GameObject Arrow; //stores the object thats placed into it (this will be the Arrow)
    public GameObject Arrow2;//stores the object thats placed into it (this will be the Arrow2)
    public GameObject Arrow3;//stores the object thats placed into it (this will be the Arrow3)
    public GameObject Arrow4;//stores the object thats placed into it (this will be the Arrow4)
    public AudioClip Bow;// this stores the audio 

    AudioSource sound;// this is used to triger the audio

    private Animator animator;//this is used to triger the audio

    void Start()
    {
        animator = GetComponent<Animator>();//this gets the animator 
        sound = GetComponent<AudioSource>();// this gets the Audiosource
    }
    void Update()
    {
        float inputY = Input.GetAxisRaw("Vertical");//this gets any verticle inpute for the player 
        float inputX = Input.GetAxisRaw("Horizontal");//this gets any Horizontal input for theplayer 

        bool walking = (Mathf.Abs(inputX) + Mathf.Abs(inputY)) > 0;//this checks to see if the player is walking

        animator.SetBool("walking", walking);// this sets the bool in the animator to true or false 

        if (walking)//if the player is walking then do something 
        {
            animator.SetFloat("x", inputX);//these triger animations
            animator.SetFloat("y", inputY);//these triger animations

            transform.position += new Vector3(inputX, inputY, 0).normalized * speed * Time.deltaTime;//this moves the player and alos by how much

        }

        if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))//this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
        {
            GameObject b = Instantiate(Arrow3);// this gets the object thats stored in Arrow 3                             
            Rigidbody2D rba = b.GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
             Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
            rba.velocity = new Vector2(30, 30);//this tells the arrow how much to move up the y and across the x                             
            rba.position = rbaa.position;//this gets the position
            b.transform.position = gameObject.transform.position;//this moves the arrow               
            animator.SetTrigger("Shot");//this sets off a animation
            sound.PlayOneShot(Bow, 1f);//this plays a sound                    

        }
        else
        {
            if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))// this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
            {
                GameObject b = Instantiate(Arrow4);// this gets the object thats stored in Arrow 4
                Rigidbody2D rba = b.GetComponent<Rigidbody2D>();//this gets the rigidbodycomponent
                Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
                rba.velocity = new Vector2(30, -30);//this tells the arrow how much to move up the y and across the x 
                rba.position = rbaa.position;//this gets the position
                b.transform.position = gameObject.transform.position; //this moves the arrow 
                animator.SetTrigger("Shot");//this sets off a animation
                sound.PlayOneShot(Bow, 1f);// this plays a sound

            }

            else

            {
                if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))// this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
                {
                    GameObject b = Instantiate(Arrow4);// this gets the object thats stored in Arrow 4
                    Rigidbody2D rba = b.GetComponent<Rigidbody2D>();//this gets the rigidbodycomponent
                    Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
                    rba.velocity = new Vector2(-30, 30);//this tells the arrow how much to move up the y and across the x 
                    rba.position = rbaa.position;//this gets the position
                    b.transform.position = gameObject.transform.position; //this moves the arrow 
                    animator.SetTrigger("Shot");//this sets off a animation
                    sound.PlayOneShot(Bow, 1f);// this plays a sound

                }



                else
                {
                        if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) // this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
                    {
                        GameObject b = Instantiate(Arrow3);// this gets the object thats stored in Arrow 3                             
                        Rigidbody2D rba = b.GetComponent<Rigidbody2D>();//this gets the rigidbodycomponent
                        Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
                        rba.velocity = new Vector2(-30, -30);//this tells the arrow how much to move up the y and across the x                                   
                        rba.position = rbaa.position;//this gets the position
                        b.transform.position = gameObject.transform.position; //this moves the arrow 
                        animator.SetTrigger("Shot");//this sets off a animation
                        sound.PlayOneShot(Bow, 1f);// this plays a sound

                    }

                    else
                    {
                        if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.D))   // this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
                        {
                            GameObject b = Instantiate(Arrow);// this gets the object thats stored in Arrow                             
                            Rigidbody2D rba = b.GetComponent<Rigidbody2D>();//this gets the rigidbodycomponent
                            Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
                            rba.velocity = new Vector2(30, 0);//this tells the arrow how much to move up the y and across the x  
                            rba.position = rbaa.position;//this gets the position
                            b.transform.position = gameObject.transform.position; //this moves the arrow 
                            animator.SetTrigger("Shot");//this sets off a animation
                            sound.PlayOneShot(Bow, 1f);// this plays a sound

                        }

                        else
                        {
                            if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.A))  // this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
                            {
                                GameObject b = Instantiate(Arrow);// this gets the object thats stored in Arrow                             
                                Rigidbody2D rba = b.GetComponent<Rigidbody2D>();//this gets the rigidbodycomponent
                                Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
                                rba.velocity = new Vector2(-30, 0);//this tells the arrow how much to move up the y and across the x                                  
                                rba.position = rbaa.position;//this gets the position
                                b.transform.position = gameObject.transform.position; //this moves the arrow 
                                animator.SetTrigger("Shot");//this sets off a animation
                                sound.PlayOneShot(Bow, 1f);// this plays a sound
                            }

                            else
                            {
                                if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.UpArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.W))   // this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
                                {
                                    GameObject b = Instantiate(Arrow2);// this gets the object thats stored in Arrow2                               
                                    Rigidbody2D rba = b.GetComponent<Rigidbody2D>();//this gets the rigidbodycomponent
                                    Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
                                    rba.velocity = new Vector2(0, 30);//this tells the arrow how much to move up the y and across the x                                    
                                    rba.position = rbaa.position;//this gets the position
                                    b.transform.position = gameObject.transform.position; //this moves the arrow 
                                    animator.SetTrigger("Shot");//this sets off a animation
                                    sound.PlayOneShot(Bow, 1f);// this plays a sound
                                }

                                else
                                {
                                    if (Input.GetKeyDown("space") && Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown("space") && Input.GetKey(KeyCode.S)) // this tells the game to do something when the Space Bar is hit and it only happens once rather than constantly
                                    {
                                        GameObject b = Instantiate(Arrow2);// this gets the object thats stored in Arrow2
                                        Rigidbody2D rba = b.GetComponent<Rigidbody2D>();//this gets the rigidbodycomponent
                                        Rigidbody2D rbaa = GetComponent<Rigidbody2D>();// this gets the rigidbodycomponent
                                        rba.velocity = new Vector2(0, -30);//this tells the arrow how much to move up the y and across the x                                    
                                        rba.position = rbaa.position;//this gets the position
                                        b.transform.position = gameObject.transform.position; //this moves the arrow 
                                        animator.SetTrigger("Shot");//this sets off a animation
                                        sound.PlayOneShot(Bow, 1f);// this plays a sound

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
