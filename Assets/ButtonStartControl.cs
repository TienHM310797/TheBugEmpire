using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

//using UnityEngine.Advertisements;

public class ButtonStartControl : MonoBehaviour
{

	public void Playasqsdq ()
	{
		menuManagerasdq.SetLoaasdqdding ("Play");
		AudioControl.Instsdfwance.clicksdfwButton ();
	}

	public void Shopawsdq ()
	{
		Application.LoadLevel ("Shop");
		AudioControl.Instsdfwance.clicksdfwButton ();
	}
	public void Playaesdq ()
	{
		menuManagerasdq.SetLoaasdqdding ("Play");
		AudioControl.Instsdfwance.clicksdfwButton ();
	}

	public void Shopqasdq ()
	{
		Application.LoadLevel ("Shop");
		AudioControl.Instsdfwance.clicksdfwButton ();
	}
	[FormerlySerializedAs("menuManager")] public MenuManager menuManagerasdq;

	public void Playasdq ()
	{
		menuManagerasdq.SetLoaasdqdding ("Play");
		AudioControl.Instsdfwance.clicksdfwButton ();
	}

	public void Shopasdq ()
	{
		Application.LoadLevel ("Shop");
		AudioControl.Instsdfwance.clicksdfwButton ();
	}
		
//	public void showAds ()
//	{
//
//		if (Advertisement.IsReady ()) {
//			Advertisement.Show (null, new ShowOptions {
//				resultCallback = result => {
//					if (result.ToString () == "Finished") {
//						PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold", 450) + 50);
//					}
//				}
//			});
//		}
//                
//	}
}
