using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {

    public void ToMain()
    {
        SceneManager.LoadScene("MainMenu");//chanes from the current scene to the mainmenu
    }
}
