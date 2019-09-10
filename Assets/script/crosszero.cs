using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class crosszero : MonoBehaviour {

    public Button button;
    public Text buttontext;

	private GC gc;

    public void setspace()
    {
        buttontext.text = gc.getplayerside();
        button.interactable = false;
        gc.EndTerm();
    }
    public void SetGameControllerReferance(GC controller)
    {
        gc = controller;
    }

	public void exit()
	{
		Application.Quit();

	}
	public void play()
	{
		SceneManager.LoadScene("main");

	}
}
