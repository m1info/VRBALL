using UnityEngine;
using UnityEngine.UI;

public class AddObject : MonoBehaviour {

    public GameObject plane;

    public GameObject v_ramps;
    public GameObject h_ramps;
    public GameObject dev_right;
    public GameObject dev_left;
    

    public Button buttonRamps;
    public Button buttonDeviation;


    // Use this for initialization
    void Start () {
        

        buttonRamps.onClick.AddListener(() => { CreateRamps(); });
        buttonDeviation.onClick.AddListener(() => { CreateDeviation(); });
    }

    // Update is called once per frame
    void Update () {

    }
    
    private void CreateDeviation()
    {
        Vector3 pos = new Vector3(plane.transform.position.x, plane.transform.position.y + 0.2f, plane.transform.position.z);
        Instantiate(dev_left, pos, dev_left.transform.rotation);
        Application.number_object_used++;
        
    }
    /*
    private void CreateRDev()
    {
        Vector3 pos = new Vector3(plane.transform.position.x, plane.transform.position.y + 0.2f, plane.transform.position.z);
        Instantiate(dev_right, pos, dev_right.transform.rotation);
        Application.number_object_used++;
    }
    
    private void CreateHRamps()
    {
        Vector3 pos = new Vector3(plane.transform.position.x, plane.transform.position.y + 0.2f, plane.transform.position.z);
        Instantiate(h_ramps, pos, h_ramps.transform.rotation);
        Application.number_object_used++;
    }
    */
    void CreateRamps()
    {
        Vector3 pos = new Vector3(plane.transform.position.x, plane.transform.position.y + 0.2f, plane.transform.position.z);
        Instantiate(v_ramps, pos, v_ramps.transform.rotation);
        Application.number_object_used++;
    }
    /*
    void CreateObctacle()
    {
        Vector3 pos = new Vector3(Random.Range(-2.0f, 2.0f), plane.transform.position.y, Random.Range(-2.0f, 2.0f));
        //Vector3 pos = new Vector3(Random.Range(-1.0f, 1.0f) + plane.transform.position.x, plane.transform.position.y + 2, Random.Range(-1.0f, 1.0f) + plane.transform.position.z);

        cubeObstacle.transform.Translate(1555, 0, 3);
        Application.number_obstacle_used++;
    }
    */

}
