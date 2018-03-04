using System.Collections;
using UnityEngine;

class DragTransform : MonoBehaviour
{
    private bool dragging = false;
    private float distance;


    void OnMouseDown()
    {
        if (Application.running) { 
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
            Application.gameObject = this.gameObject;
        }
    }

    void OnMouseUp()
    {
        if (Application.running)
        {

            dragging = false;
        }
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = new Vector3(rayPoint.x, transform.position.y,rayPoint.z);
        }
    }
}
