using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public void Quit()
    {
        UnityEngine.Debug.Log("QUIT");
        Application.Quit();
    }
}
