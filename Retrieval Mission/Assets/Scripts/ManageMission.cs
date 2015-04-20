using UnityEngine;
using System.Collections;

public class ManageMission : MonoBehaviour
{

    public GameObject WinCanvas;
    public GameObject StandAloneVersionRobot;
    public GameObject MobileVersionRobot;

    void Awake()
    {
        NotificationCenter.DefNotCenter.AddObserver(this, "OnWin");
        if (Application.isMobilePlatform)
        {
            MobileVersionRobot.SetActive(true);
        }
        else
        {
            StandAloneVersionRobot.SetActive(true);
        }
    }
    void OnWin()
    {
        WinCanvas.SetActive(true);
        if (Application.isMobilePlatform)
        {
            MobileVersionRobot.SetActive(false);
        }
        else
        {
            StandAloneVersionRobot.SetActive(false);
        }
    }

    void OnLose()
    {

    }


}
