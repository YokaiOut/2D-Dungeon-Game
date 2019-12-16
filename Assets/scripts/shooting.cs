using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour
{
    public GameObject RedGhost;//this stores an object 

    public float DistanceFromEnemy;//this is the distance from the player
    public float CoolDown;//this is the variable for cooldown
    public GameObject Player;// this is the gameobject for the player 
    public GameObject Enemy;//this is the gameobject for the current mage 
    public int Aggro = 50;//this is the distance that it can start to do something 
        
    private Animator animator;  //is used when we need to call the animator                                              

    private const int SPAWN_DISTANCE = 5;// this is the distance that the projectiles spawn at 


    // Use this for initialization
    void Start()
    {

        CoolDown = 4;//this is the time that the mage can shoot again 
        animator = GetComponent<Animator>();//this tells the game that it needs to call the animator 
    }
    // Update is called once per frame
    void Update()
    {

        Player = GameObject.FindGameObjectWithTag("Player");// this finds the player 

        if (Player != null)//this says if their is a player do something 
        {
            DistanceFromEnemy = Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, Enemy.transform.position);//this gets the distance from the player
         
            if (DistanceFromEnemy <= Aggro) //this says if the distance is below the aggro range then do something 
            {
                attackPlayer();// this calls the function 
            }

        }
    }
    void attackPlayer()
    {
        
        CoolDown -= Time.deltaTime; // this counts down from 4 till 0 and it can shoot 
        if (CoolDown <= 0)// if cooldown is 0 do something 
        {
            animator.SetTrigger("Cast");// this calls an animation                             
            Instantiate(RedGhost, transform.position + SPAWN_DISTANCE * transform.forward, transform.rotation);// this moves the projectile 

            CoolDown = 4;// this sets the cooldown back to 4
        }
    }
}