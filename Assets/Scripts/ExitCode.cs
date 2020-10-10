using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCode : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            // Quite App
            Application.Quit();
        }
        
    }
}
