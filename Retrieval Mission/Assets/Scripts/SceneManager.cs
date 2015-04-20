using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{

    public void LoadScene(string scene)
    {
        Application.LoadLevel(scene);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Escape))
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
