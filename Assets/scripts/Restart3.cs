using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart3 : MonoBehaviour {

    public void Restart()
    {
        SceneManager.LoadScene("Scene3");// this moves from  the cutrrent scene to scene3
    }
}
