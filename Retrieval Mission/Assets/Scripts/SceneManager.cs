using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    //public GameObject progress;

    void Awake()
    {
        if (Application.loadedLevelName.Equals("MissionSelector"))
        {
            Debug.Log("Awaken");
            //progress = GameObject.
        }

    }
    public void LoadScene(string scene)
    {
        Application.LoadLevel(scene);
    }


    public void LoadLevelAsync(string scene)
    {

        //AsyncOperation operation = Application.LoadLevelAdditiveAsync(scene);
        //var pro = progress.GetComponent<Text>();

        //pro.text = operation.progress.ToString("f0") + "%";
    }

    // Update is called once per frame
    void Update()
    {

        if (Application.isLoadingLevel && Application.loadedLevelName.Equals("MissionSelector"))
        {

        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Menu) || Input.GetKeyDown(KeyCode.Backspace))
        {
            Application.Quit();

        }


    }

    public void LoadFacebookPage()
    {
        Application.OpenURL("https://www.facebook.com/pages/Retrieval-Mission/1438021939830019");
    }

    public void LoadTwitterPage()
    {
        Application.OpenURL("https://twitter.com/RetrievalM");
    }
}
