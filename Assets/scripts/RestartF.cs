using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartF : MonoBehaviour {

    public void Restart()
    {
        SceneManager.LoadScene("Final");// this moves from  the cutrrent scene to final
    }
}
