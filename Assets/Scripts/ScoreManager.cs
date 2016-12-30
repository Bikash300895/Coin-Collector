using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score = 0;
    public Text scoreText;
    public Text timeText;
    int time = 120;
    int extime;

    // Use this for initialization
    void Start () {
        extime = (int)Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(score.ToString());
        scoreText.text = "Coins : " +score.ToString();
        Debug.Log(Time.time);
        int gametime = (int)Time.time - extime;

        timeText.text = "Time " + ((time - gametime) / 60).ToString() + " : " + ((time - gametime) % 60).ToString();


        if (gametime>=time)
        {
            Application.LoadLevel("03 GameOver");
        }
    }

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        Application.LoadLevel(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
