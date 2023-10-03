using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;


public class shopScenes : MonoBehaviour
{
	public void HomeButoosnasd2q ()
	{
		Application.LoadLevel ("Home");
	}

	public void showAdsaasdq ()
	{
//		if (Advertisement.IsReady())
//		{
//			Advertisement.Show("rewardedVideo", new ShowOptions
//				{
//					resultCallback = result =>
//					{
//						if (result.ToString() == "Finished")
//						{
//							PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 200);
//							thuong.SetActive(true);
//							if (ads.activeInHierarchy == true)
//							{
//								ads.SetActive(false);
//							}
//						}
//					}
//				});
//		}
                 
	}

	public void candclesAdsasdq ()
	{
		asdwads.SetActive (false);
	}

	[FormerlySerializedAs("thuong")] public GameObject thuonasdqg;
	[FormerlySerializedAs("ads")] public GameObject asdwads;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel ("Home");
		}
	}


	public void HomeButoonasd2q ()
	{
		Application.LoadLevel ("Home");
	}

	public void showAdsasdq ()
	{
//		if (Advertisement.IsReady())
//		{
//			Advertisement.Show("rewardedVideo", new ShowOptions
//				{
//					resultCallback = result =>
//					{
//						if (result.ToString() == "Finished")
//						{
//							PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 200);
//							thuong.SetActive(true);
//							if (ads.activeInHierarchy == true)
//							{
//								ads.SetActive(false);
//							}
//						}
//					}
//				});
//		}
                 
	}

	public void candcleAdsasdq ()
	{
		asdwads.SetActive (false);
	}
}
