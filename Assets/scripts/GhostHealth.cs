using UnityEngine;
using System.Collections;

public class GhostHealth : MonoBehaviour
{
    public float Health;// this holds how much health the object has
    public AudioClip Death;//this holds the sound 

    AudioSource sound;//this is used to trigger the sound

    void Start()
    {
        sound = GetComponent<AudioSource>();//this gets the audiosource
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))//if it matches the tag do something 
        {
            Health = Health - 50;//take 50 away from the health
            other.gameObject.SetActive(false);//destroy other gameobject
        }

        if (other.gameObject.CompareTag("Arrow2"))//if it matches the tag do something 
        {
            Health = Health - 50;//take 50 away from the health
            other.gameObject.SetActive(false);//destroy other gameobject
        }

        if (other.gameObject.CompareTag("Player"))//if it matches the tag do something 
        {
            Health = Health - 50;//take 50 away from the health
            sound.PlayOneShot(Death, 1f);//play sound
        }

        if (Health == 0)//if it matches the tag do something 
        {
            Destroy(gameObject);//destory this object
        }
    }
}