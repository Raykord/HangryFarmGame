using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public static class AddScore
{
	private static int score;
	public static void ScoreAdd()
	{
		score++;
		Debug.LogFormat("Score = {0}", score);
	}
	
	public static string GetScore()
	{
		return score.ToString();
	}
}
