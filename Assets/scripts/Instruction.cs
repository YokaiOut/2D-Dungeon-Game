using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour {

    public void ToInst()
    {
        SceneManager.LoadScene("Inst");// this moves from  the cutrrent scene to the instructions page
    }
}
