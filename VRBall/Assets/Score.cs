using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public Text result;
    public Text score;
    public Button restart;


    // Use this for initialization
    void Start () {
        restart.onClick.AddListener(() => { Restart(); });

        if (Application.win)
        {
            result.text = "Felicitations! Vous avez gagné";
            score.text = ("Votre score est : " + (100 / Application.timer - Application.number_object_used*5));

        }
        else
        {
            result.text = "Game Over! Vous avez perdu";
            score.text = ("Votre score est : 0");

        }



    }
    private void Restart()
    {
        Debug.Log("restart");
        SceneManager.LoadScene("init");


    }

    // Update is called once per frame
    void Update () {
		
	}
}
