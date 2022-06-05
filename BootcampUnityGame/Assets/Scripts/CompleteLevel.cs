using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{


	
	public void Continue()
	{

		SceneManager.LoadScene("2.level");
	}

	public void Menu()
	{
		SceneManager.LoadScene("MainMenu");
	}

}
