using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {


 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            NotificationCenter.DefNotCenter.PostNotification(this,"OnCollect");
            this.gameObject.SetActive(false);
        }
    }
}
