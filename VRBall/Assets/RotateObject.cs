using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{

    GameObject objectRotate;

    public float rotateSpeed = 5f;
    bool rotateStatus = false;

    public void Rotasi()
    {

        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        objectRotate = Application.gameObject;
        if (rotateStatus == true && objectRotate != null)
        {
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
