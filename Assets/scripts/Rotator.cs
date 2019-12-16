using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);// this spins the ameobject 45 derees in the Z position
	}
}
