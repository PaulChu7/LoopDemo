using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	[SerializeField] private GameManagerScript newGame;
	public void LoadScene(int sceneid)
	{
		SceneManager.LoadScene(sceneid);
		if (sceneid == 1)
        {
			newGame.NewGame();
        }
	}

	public void Exit()
	{
		Application.Quit();
	}

}
