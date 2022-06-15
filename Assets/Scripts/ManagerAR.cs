using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAR : MonoBehaviour
{
    public GameObject panel;




    public void OnDestroyPanel()
    {
        panel.SetActive(false);
    }


}
