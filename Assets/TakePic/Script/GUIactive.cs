using UnityEngine;
using System.Collections;

public class GUIactive : MonoBehaviour
{
	public enum MODE
	{
		SHOW,
		HIDE
	}
	public MODE mode;
	public GameObject myGUI;
	public GameObject pic;
	public GameObject khung;

	public GameObject buttonTakePicture;
	public GameObject[] listbutton;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{
		switch (mode) {
		case MODE.SHOW:
			myGUI.SetActive (true);
			break;
		case MODE.HIDE:
			myGUI.SetActive (false);
			break;
		}
		khung.SetActive (false);
		pic.GetComponent<SpriteRenderer> ().sprite = null;

		buttonTakePicture.SetActive(true);
		for(int i=0; i<listbutton.Length;i++){
			listbutton[i].SetActive(true);
		}

		//ManagerLevel2.ml2.ButtonChupAnh.SetActive(true);
		//Application.LoadLevel("Home");
	}
}
