using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Initialize : MonoBehaviour {

    public Button easy;
    public Button hard;

	// Use this for initialization
	void Start () {
        easy.onClick.AddListener(() => { LoadEasy("easy"); });
        hard.onClick.AddListener(() => { LoadEasy("hard"); });
    }

    private void LoadEasy(String level)
    {
        Application.timer = 0;
        Application.level = level;
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
