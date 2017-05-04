using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtuns : MonoBehaviour 
{

	public void RestartGame()
	{
		SceneManager.LoadScene (0);
	}
	public void QuitGame()
	{
		Application.Quit();
	}

}
