using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public Player player;

	[SerializeField]
	private FloatSO scoreSO;
	[SerializeField]
	private float warmUpScore = 30;

	public TextMeshProUGUI scoreText;

	private void Awake()
	{
		instance = this;
		player = FindObjectOfType<Player>();
		if (SceneManager.GetActiveScene().name == "EasyScene")
		{
			scoreSO.Value = 0;
		}
	}

	void Start()
	{
		scoreText.SetText(scoreSO.Value.ToString());
	}


	void Update()
	{
		scoreText.SetText(scoreSO.Value.ToString());

		if (scoreSO.Value >= warmUpScore)
		{
			if (SceneManager.GetActiveScene().name == "EasyScene")
			{
				SceneManager.LoadSceneAsync("MapChange");
			}
		}
	}
}