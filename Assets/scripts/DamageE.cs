using UnityEngine;
using System.Collections;

public class DamageE : MonoBehaviour
{
    public float Health;//this holds the health of the object

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))//if it matches the tag do something
        {
            Health = Health - 50;//take 50 from health
            other.gameObject.SetActive(false);//destory other game object
        }

        if (other.gameObject.CompareTag("Arrow2"))//if it matches the tag do something
        {
            Health = Health - 50;//take 50 from health
            other.gameObject.SetActive(false);//destory other game object
        }

        if (Health == 0)//if it matches the tag do something
        {
            Destroy(gameObject);//destory this game object
        }
    }
}

