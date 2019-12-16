using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("scene 1");//this moves from the current scene to scene 1
    }
}
