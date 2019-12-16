using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Exit2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))// if the object has the same tag do something 
        {
            SceneManager.LoadScene("Scene3");// this moves from  the cutrrent scene to scene3
        }
    }
}
