using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart2 : MonoBehaviour {

    public void Restart()
    {
        SceneManager.LoadScene("Scene2");// this moves from  the cutrrent scene to scene3
    }
}
