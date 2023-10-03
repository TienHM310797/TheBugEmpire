using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemControl : MonoBehaviour
{
	public void FocuadaqsBoom ()
	{
		if (PlayerPrefs.GetInt ("itembom", 1) > 0) {
			Instantiate (asdqoom, Camera.main.ScreenToWorldPoint (Input.mousePosition), Quaternion.identity);
			PlayerPrefs.SetInt ("itembom", PlayerPrefs.GetInt ("itembom", 1) - 1);
		} else {
			UIRootadqqq.SetActive (false);
			shasdqop.SetActive (true);
		}
	}

	public void closasdsdqeShop ()
	{
		shasdqop.SetActive (false);
		UIRootadqqq.SetActive (true);
		_lbasdq.text = PlayerPrefs.GetInt ("gold", 450) + "";
	}
    

	public void cancadqasleads ()
	{
		popUpasdq.SetActive (false);
	}

	public void ssdaqqq ()
	{
		asdmenuManagerqq.SetLoaasdqdding ("Home");
//		Application.LoadLevel ("Home");
	}
	[FormerlySerializedAs("efBoom")] public GameObject asdqoom;
	[FormerlySerializedAs("efNT")] public GameObject easdqfNT;
	[FormerlySerializedAs("shop")] public GameObject shasdqop;
	[FormerlySerializedAs("_lb")] public Text _lbasdq;
	[FormerlySerializedAs("thuong")] public GameObject thuongasdq;
	[FormerlySerializedAs("popUp")] public GameObject popUpasdq;
	[FormerlySerializedAs("UIRoot")] public GameObject UIRootadqqq;
	[FormerlySerializedAs("menuManager")] public MenuManager asdmenuManagerqq;
	[FormerlySerializedAs("shopDiamond")] public GameObject adqshopDiamondaaa;

	void Start ()
	{
//		PlayerPrefs.DeleteAll();
//		PlayerPrefs.GetInt("itemcamap",1);
	}

	public void DestroyCasdqaMap ()
	{
		if (PlayerPrefs.GetInt ("itemcamap", 1) > 0) {
			while (FishManage.Inasdqstance._CaasdMapManagew.Count > 0) {
				Transform aFish = FishManage.Inasdqstance._CaasdMapManagew [0];
				FishManage.Inasdqstance._CaasdMapManagew.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitDameasdq (10000, asdqoom);
			}
			PlayerPrefs.SetInt ("itemcamap", PlayerPrefs.GetInt ("itemcamap", 1) - 1);
			AudioControl.Instsdfwance.clicksdfwButton ();
		} else {
			UIRootadqqq.SetActive (false);
			shasdqop.SetActive (true);
		}
	}

	public void DestasdqroyMuc ()
	{
		if (PlayerPrefs.GetInt ("itemmuc", 1) > 0) {
			while (FishManage.Inasdqstance._MwucMaasdqnager.Count > 0) {
				Transform aFish = FishManage.Inasdqstance._MwucMaasdqnager [0];
				FishManage.Inasdqstance._MwucMaasdqnager.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitDameasdq (10000, asdqoom);
			}
			PlayerPrefs.SetInt ("itemmuc", PlayerPrefs.GetInt ("itemmuc", 1) - 1);
			AudioControl.Instsdfwance.clicksdfwButton ();
		} else {
			UIRootadqqq.SetActive (false);
			shasdqop.SetActive (true);
		}
	}

	public void adsqDestroyAll ()
	{
		if (PlayerPrefs.GetInt ("itemnt", 1) > 0) {
			AudioControl.Instsdfwance.nguyensdfwtu ();
			while (FishManage.Inasdqstance._FishMangeasdq.Count > 0) {
				Transform aFish = FishManage.Inasdqstance._FishMangeasdq [0];
				FishManage.Inasdqstance._FishMangeasdq.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitDameasdq (10000, asdqoom);
			}
			Instantiate (easdqfNT, Vector3.zero, Quaternion.identity);
			PlayerPrefs.SetInt ("itemnt", PlayerPrefs.GetInt ("itemnt", 1) - 1);
		} else {
			UIRootadqqq.SetActive (false);
			shasdqop.SetActive (true);
		}
	}

	public void ItemXasdq2q ()
	{
		if (PlayerPrefs.GetInt ("itemx2", 1) > 0) {
			CancelInvoke ("ReseadqtGoldBonus");
			GunControl.BoasdqnusCoin = 2;
			Invoke ("ReseadqtGoldBonus", 30);
			PlayerPrefs.SetInt ("itemx2", PlayerPrefs.GetInt ("itemx2", 1) - 1);
			AudioControl.Instsdfwance.clicksdfwButton ();
		} else {
			UIRootadqqq.SetActive (false);
			shasdqop.SetActive (true);
		}
	}

	public void asdqdX3 ()
	{
		if (PlayerPrefs.GetInt ("itemx3", 1) > 0) {
			CancelInvoke ("ReseadqtGoldBonus");
			GunControl.BoasdqnusCoin = 3;
			Invoke ("ReseadqtGoldBonus", 30);
			PlayerPrefs.SetInt ("itemx3", PlayerPrefs.GetInt ("itemx3", 1) - 1);
			AudioControl.Instsdfwance.clicksdfwButton ();
		} else {
			UIRootadqqq.SetActive (false);
			shasdqop.SetActive (true);
		}
	}

	void ReseadqtGoldBonus ()
	{
		GunControl.BoasdqnusCoin = 1;
	}

	public void FocuadqsBoom ()
	{
		if (PlayerPrefs.GetInt ("itembom", 1) > 0) {
			Instantiate (asdqoom, Camera.main.ScreenToWorldPoint (Input.mousePosition), Quaternion.identity);
			PlayerPrefs.SetInt ("itembom", PlayerPrefs.GetInt ("itembom", 1) - 1);
		} else {
			UIRootadqqq.SetActive (false);
			shasdqop.SetActive (true);
		}
	}

	public void closasdqeShop ()
	{
		shasdqop.SetActive (false);
		UIRootadqqq.SetActive (true);
		_lbasdq.text = PlayerPrefs.GetInt ("gold", 450) + "";
	}
    

	public void cancadqleads ()
	{
		popUpasdq.SetActive (false);
	}

	public void homasdqdwButton ()
	{
		asdmenuManagerqq.SetLoaasdqdding ("Home");
//		Application.LoadLevel ("Home");
	}
}
