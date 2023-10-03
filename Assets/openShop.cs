using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class openShop : MonoBehaviour {

    public void OpenasdsqShop()
    {
//		GunControl.checkTouch =false;
        UiRootasdq.SetActive(false);
        popasdqUp.SetActive(true);
    }public void OpenasdqqShop()
    {
//		GunControl.checkTouch =false;
        UiRootasdq.SetActive(false);
        popasdqUp.SetActive(true);
    }
    [FormerlySerializedAs("popUp")] public GameObject popasdqUp;
	[FormerlySerializedAs("UiRoot")] public GameObject UiRootasdq;
    public void OpenasdqShop()
    {
//		GunControl.checkTouch =false;
		UiRootasdq.SetActive(false);
        popasdqUp.SetActive(true);
    }
}
