using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour
{
	public void OnContinueuttonClicked()
	{
		SceneManager.LoadSceneAsync("HardScene");
	}
}
