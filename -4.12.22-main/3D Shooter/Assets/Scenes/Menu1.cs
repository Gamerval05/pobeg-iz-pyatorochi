using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour
{
	public GameObject menu;
    public GameObject settingsmenu;

    public void Play()
	{
		SceneManager.LoadScene(1);
	}

	public void Settings()
	{
		menu.SetActive(false);
		settingsmenu.SetActive(true);
	}

	public void Exit()
	{
        SceneManager.LoadScene(0);
    }
	public void ExitSettings()
	{
        SceneManager.LoadScene(0);
    }
}
