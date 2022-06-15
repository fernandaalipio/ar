using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Internet : MonoBehaviour
{

    public Text checkConnect;                   //Texto com frase sem conexão
    public string[] textCheckConnect;           

    public bool statusInternetPause;
    void Update()
    {


        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            checkConnect.text = textCheckConnect[0];

            Time.timeScale = 1;
            statusInternetPause = true;
        }
        else
        {
            checkConnect.text = textCheckConnect[1];

            Time.timeScale = 0;

            statusInternetPause = false;

        }
    }

}
