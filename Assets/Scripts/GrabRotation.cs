using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRotation : MonoBehaviour
{
    public GameObject objectRotate;

    public float rotationSpeed;

    public bool statusRotate;

    public void RotateObject(bool status)
    {
        statusRotate = status;
    }

    private void Update()
    {
        if (statusRotate == true)
        {
            objectRotate.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, 0);
        }
        else
        {

        }
    }
}
