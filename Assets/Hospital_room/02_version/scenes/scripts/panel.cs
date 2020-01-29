using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if (Panel != null) {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }    
    
    }

    public void ClosePanel()
    {
        if (Panel.activeSelf == true) {
            Panel.SetActive(false);
        }
        

    }
}
