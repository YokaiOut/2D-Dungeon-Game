using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;//this holds the game object

    private Vector3 offset;// this holds a position

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position;//this gets the position
	}

	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;//this moves the camera
	}
}
