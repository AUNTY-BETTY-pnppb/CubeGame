using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class begin : MonoBehaviour
{
    public void StartGame()
    {
        UnityEngine.Debug.Log("BEGIN");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
