using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Exit3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))// if the object has the same tag do something 
        {
            SceneManager.LoadScene("Final");// this moves from  the cutrrent scene to the final
        }
    }
}

