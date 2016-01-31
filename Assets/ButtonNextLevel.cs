using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonNextLevel : MonoBehaviour 
{
	public void NextLevelButton(int index)
	{
		SceneManager.LoadScene(index);
	}

	public void NextLevelButton(string levelName)
	{
		SceneManager.LoadScene(levelName);
	}
}
