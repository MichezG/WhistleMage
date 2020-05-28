using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player_Score : MonoBehaviour {

    private float timeLeft = 120;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;

    void Update() {
        //Debug.Log(timeLeft);
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        if (timeLeft < 0.1f) {
            SceneManager.LoadScene("SemesterProject_01");

        }
    }

    void OnTriggerEnter2D (Collider2D trig) {
        if (trig.gameObject.name == "EndLevel"){
            CountScore ();
        }
        if (trig.gameObject.name == "Coin") {
            playerScore += 10;
            Destroy(trig.gameObject);
        }
        //Debug.Log("Touched the end of the Level");
    }

    void CountScore() {
        playerScore = playerScore + (int)(timeLeft * 10);
        Debug.Log(playerScore);
    }
}
