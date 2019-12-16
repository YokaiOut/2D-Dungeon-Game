using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        Destroy(gameObject, 5);//this destroys the object after 5 seconds

    }
}