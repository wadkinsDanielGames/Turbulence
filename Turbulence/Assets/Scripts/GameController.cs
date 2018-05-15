using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	//declarations
	public int scoreRed;
	public int scoreBlue;
	public int maxScore;
	public int countdownnum;
	public bool gameOver = false;
	public GameObject redVictory;
	public GameObject blueVictory;
	public GameObject ball;
	public GameObject redGoal;
	public GameObject blueGoal;
	public GameObject nm;
	//private int numPlayersInLobby;
	//public int maxCapacity;

	//ui
	public Text countDown;


	//notifications
	public static event Action GoBabyGo;

	// Use this for initialization
	void Start () {
		scoreRed = 0;
		scoreBlue = 0;
		//numPlayersInLobby = 0;

		//subscriptions
		//I may not even need subscriptions anymore!!!
    }

	

	// Update is called once per frame
	void Update () {
		if (scoreRed == maxScore)
		{
			redVictory.SetActive(true);
		}
		if (scoreBlue == maxScore)
		{
			blueVictory.SetActive(true);
		}

	}

	void OnEnable()
	{
		ScoreRed.pointRed += pointRed;
		ScoreBlue.pointBlue += pointBlue;
	}
	void OnDisable()
	{
		ScoreRed.pointRed -= pointRed;

	}

	public void pointRed()
	{
		scoreRed = scoreRed + 1;
		print("scored!");
	}
	public void pointBlue()
	{
		scoreBlue++;
	}

}