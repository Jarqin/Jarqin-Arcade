using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
	public int score;
	public Text scoreDisplay;
	public Text scoreOver;

	private void Update()
	{
		scoreDisplay.text = score.ToString();
		scoreOver.text = score.ToString();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Ball"))
		{
			score++;
			Debug.Log(score);	
		}
	}
}