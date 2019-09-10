using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GC : MonoBehaviour {

    public Text[] buttonlist;
	private string playerSide;
	public GameObject gop;
	public Text got;

	private int count;

    void Awake()
    {
		gop.SetActive (false);
        SetGameControllerReferanceOnButtons();
		playerSide = "X";
		count = 0;
    }
    

    void SetGameControllerReferanceOnButtons()
    {
        for(int i=0;i<buttonlist.Length;i++)
        {
			buttonlist[i].GetComponentInParent<crosszero>().SetGameControllerReferance(this);
        }
    }

    public string getplayerside()
    {
		return playerSide;

    }
    public void EndTerm()
    {
		count++;
		if (buttonlist [0].text == playerSide && buttonlist [1].text == playerSide && buttonlist [2].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [0].text == playerSide && buttonlist [1].text == playerSide && buttonlist [2].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [3].text == playerSide && buttonlist [4].text == playerSide && buttonlist [5].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [6].text == playerSide && buttonlist [7].text == playerSide && buttonlist [8].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [0].text == playerSide && buttonlist [3].text == playerSide && buttonlist [6].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [1].text == playerSide && buttonlist [4].text == playerSide && buttonlist [7].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [2].text == playerSide && buttonlist [5].text == playerSide && buttonlist [8].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [0].text == playerSide && buttonlist [4].text == playerSide && buttonlist [8].text == playerSide) {
			Gameover ();
		}

		if (buttonlist [2].text == playerSide && buttonlist [4].text == playerSide && buttonlist [6].text == playerSide) {
			Gameover ();
		}
		if (count >= 10) {
	
			gop.SetActive (true);
			got.text = " DRAW ";
		
		}


		Changeside();
    }
	 
	void Gameover()
	{
		for(int i=0;i< buttonlist.Length;i++)
		{
			buttonlist [i].GetComponentInParent<Button> ().interactable = false;
		}

		gop.SetActive (true);
		got.text = playerSide + " WINS";
	}

	void Changeside()
	{
		playerSide = (playerSide == "X") ? "0" : "X";
	}


}
