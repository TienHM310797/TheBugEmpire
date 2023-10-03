using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loadding : MonoBehaviour {

	// Use this for initialization
	public float loaddingTime;
	public Image loaddingBar;
	public string NameLoadLevel;
	public static int index;
	void Start () {
		loaddingBar.fillAmount=0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(loaddingBar.fillAmount<=1){
			loaddingBar.fillAmount+=1.0f/loaddingTime*Time.deltaTime;

		}
		if(loaddingBar.fillAmount==1){
			index++;
			Application.LoadLevel(NameLoadLevel);
//			MyAdsManager.Instance.ShowInterStitial();
		}
	}
}
