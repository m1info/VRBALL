using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using UnityEngine.UI;
public class MoveBall : MonoBehaviour
{

    public GameObject ball;
    public Boolean launched = false;
    public Vector3 ballPosition;
    public float ballSpeed;

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => { StartBall(); });
    }

    private void StartBall()
    {
        if (!launched)
        {
            Application.timer += Time.deltaTime;
            Application.running = false;
            ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 8, ForceMode.Impulse);
            launched = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("elle se trouve a :" + ball.transform.position.z);
        if (launched)
        {
            //Debug.Log("launched!!!!!!!!!!");
            if (ball.transform.position.z < -4.9)
            {
                Debug.Log("Je gagne!");
                Application.running = true;
                Application.win = true;
                launched = false;
                SceneManager.LoadScene("end");
            }

            ballSpeed = ball.GetComponent<Rigidbody>().velocity.magnitude;
            if (ballSpeed < 0.37f && ballSpeed > 0.0f)
            {

                Debug.Log("Game Over!");
                Application.running = true;
                Application.win = false;
                launched = false;
                SceneManager.LoadScene("end");
                //Debug.Log("Game Over :" + ballSpeed);
            }

            if (ball.transform.position.y > 0.5)
            {
                ball.GetComponent<Rigidbody>().useGravity = true;
            }
            if (ball.transform.position.y < 0.2)
            {
                ball.GetComponent<Rigidbody>().useGravity = false;
            }


        }

    }
}
