using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject ObjectShow;

    public void OpenPanel()
    {
        if(ObjectShow != null)
        {
            bool isActive = ObjectShow.activeSelf;
            ObjectShow.SetActive(!isActive);
        }
    }
}
