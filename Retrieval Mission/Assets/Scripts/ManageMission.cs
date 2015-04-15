using UnityEngine;
using System.Collections;

public class ManageMission : MonoBehaviour {

    public GameObject winCanvas ;

    void Awake()
    {
        NotificationCenter.DefNotCenter.AddObserver(this,"OnWin");
    }
    void OnWin()
    {
        winCanvas.SetActive(true);
    }



}
