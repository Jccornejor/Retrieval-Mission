using UnityEngine;
using System.Collections;

public class LoadMainMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isMobilePlatform)
        {
            if (Input.GetTouch(0).tapCount > 0)
            {
                Application.LoadLevel("MainMenu");
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.LoadLevel("MainMenu");
            }
        }

    }
}
