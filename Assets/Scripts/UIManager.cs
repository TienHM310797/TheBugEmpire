using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIManager : MonoSingleton<UIManager>
{
	public void EnablasdqaePopUpCoin(){
		UiRootadsq.SetActive(false);
		asdqpopUp.SetActive(true);
	}

	public void DisablePqwwqwopUpCoinasd(){
		UiRootadsq.SetActive(true);
		asdqpopUp.SetActive(false);
	}

	public void OpenPopawesdUpDiamwqond(){
		UiRootadsq.SetActive(false);
		popUpDiasdqamond.SetActive(true);
	}

	public void ClowsqqeShopDiaasdqmond ()
	{
		UiRootadsq.SetActive (true);
		popUpDiasdqamond.SetActive (false);
	}
	[FormerlySerializedAs("_lb")] public Text _lbasdq;
	[FormerlySerializedAs("thuong")] public GameObject thuoasdqng;
	[FormerlySerializedAs("popUp")] public GameObject asdqpopUp;
	[FormerlySerializedAs("popUpDiamond")] public GameObject popUpDiasdqamond;
	[FormerlySerializedAs("UiRoot")] public GameObject UiRootadsq;


	public void EndBuasdqySucssess ()
	{
		PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold", 450) + 200);
		thuoasdqng.SetActive (true);
		_lbasdq.text = "" + PlayerPrefs.GetInt ("gold", 450);
		if (asdqpopUp.activeInHierarchy == true) {
			UiRootadsq.SetActive(true);
			asdqpopUp.SetActive (false);
		}
	}

	public void EnablasdqePopUpCoin(){
		UiRootadsq.SetActive(false);
		asdqpopUp.SetActive(true);
	}

	public void DisablePqwwwopUpCoinasd(){
		UiRootadsq.SetActive(true);
		asdqpopUp.SetActive(false);
	}

	public void OpenPopasdUpDiamwqond(){
		UiRootadsq.SetActive(false);
		popUpDiasdqamond.SetActive(true);
	}

	public void ClowseShopDiaasdqmond ()
	{
		UiRootadsq.SetActive (true);
		popUpDiasdqamond.SetActive (false);
	}
}
