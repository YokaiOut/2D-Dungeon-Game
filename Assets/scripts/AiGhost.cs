using UnityEngine;
using System.Collections;

public class AiGhost : MonoBehaviour
{
    public GameObject Player; // this is where the player object thats in the scene will go 
    public Transform Ghost; // this is the ghosts object thats in the scene 
    public float Speed = 1f; // this is the speed of the host but its changed in the prefab

    public float AggroRange = 30f; //this is the distances that the player has to enter for the ghost to start to come to the player 
    private float Distance; // this is a variable that will hold the distance between the ghost and the player 


    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player"); //this finds the player with the tag 'player'

        Distance = Vector2.Distance(Ghost.position, GameObject.FindGameObjectWithTag("Player").transform.position);//this gets the distance between the host and the player 

        if (Distance < AggroRange) // this says if the distance is less than the aggro range then the host will do somwthing
        {

            Distance = Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);// this gets the distance of the player as it moves
            transform.position = Vector2.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, Speed * Time.deltaTime);//this moves the ghost to the player

        }
    }
}

