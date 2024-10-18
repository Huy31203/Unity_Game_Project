using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOVer : MonoBehaviour
{
	[SerializeField]
	private FloatSO scoreSO;
	
	public TextMeshProUGUI resultText;

	void Start()
	{
		resultText.SetText("Your score is: " + scoreSO.Value.ToString());
	}

	public void OnPlayAgainButtonClicked()
	{
		scoreSO.Value = 0;
		SceneManager.LoadSceneAsync("EasyScene");
	}

	public void OnExitButtonClicked()
	{
		Application.Quit();
	}
}
