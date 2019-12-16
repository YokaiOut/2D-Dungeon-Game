using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))//this only happens if the tag matches 
        {
            other.gameObject.SetActive(false);//this destroys the object
        }

        if (other.gameObject.CompareTag("Arrow2"))//this only happens if the tag matches 
        {
            other.gameObject.SetActive(false);//this destroys the object
        }

        if (other.gameObject.CompareTag("Arrow3"))//this only happens if the tag matches 
        {
            other.gameObject.SetActive(false);//this destroys the object

        }

        if (other.gameObject.CompareTag("Arrow4"))//this only happens if the tag matches 
        {
            other.gameObject.SetActive(false);//this destroys the object
        }

    }
}