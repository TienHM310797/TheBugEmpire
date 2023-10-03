using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class MenuManager : MonoBehaviour {

	public void CliasdqckwHome(){
		Application.LoadLevel("Home");
	}

	public void ClickasdqqqYesExit(){
		Application.Quit();
	}
	public void CLickCanasedqqcelExit(){
//		MyAdsManager.Instance.ShowBanner();
		boxEadsqxit.SetActive(false);
	}

	public void ClickCanceqasdqlNoBaweqwenner(){
		boxEadsqxit.SetActive(false);
	}
    
	public void ViweewwesiblePanelqweqwe(){
		panasdqel.SetActive(false);
		butasdqwetonNext.SetActive(false);
//		AudioManager.audioManager.StopSingle(null);
	}

	public void ReplayqweqweweqScene(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void EnebleasdqweqwePanel(){
		panasdqel.SetActive(true);
		butasdqwetonNext.SetActive(false);
//		AudioManager.audioManager.PlaySingle(playAudio,false);

	}
	[FormerlySerializedAs("groupSetting")] public GameObject groupSasdqetting;
	private bool cheadqck;
	[FormerlySerializedAs("loadding")] public GameObject loadasdqding;
	[FormerlySerializedAs("btnMusic")] public GameObject btnMusicasdq;
	[FormerlySerializedAs("playAudio")] public AudioClip asdqwd;
	[FormerlySerializedAs("boxExit")] public GameObject boxEadsqxit;
	[FormerlySerializedAs("checkShowBanner")] public bool asdqcheckShowBanner;
	[FormerlySerializedAs("panel")] public GameObject panasdqel;
	[FormerlySerializedAs("buttonNext")] public GameObject butasdqwetonNext;
	[FormerlySerializedAs("audioClip")] public AudioClip audioasdqClip;

	[FormerlySerializedAs("UIRoot")] public GameObject UIasdqqRoot;
	// Use this for initialization
	void Start () {
		cheadqck = true;
//		if(btnMusic!=null){
//			if(MainStatic.CHECK_VOLUM){
//				btnMusic.transform.GetChild (0).gameObject.SetActive (true);
//				btnMusic.transform.GetChild (1).gameObject.SetActive (false);
//				AudioListener.pause = false;
//			}else{
//				btnMusic.transform.GetChild (0).gameObject.SetActive (false);
//				btnMusic.transform.GetChild (1).gameObject.SetActive (true);
//				AudioListener.pause = true;
//
//			}
//		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(boxEadsqxit.activeSelf){
				if(UIasdqqRoot!=null){
					UIasdqqRoot.SetActive(true);
				}
				boxEadsqxit.SetActive(false);
				if(asdqcheckShowBanner){
//					MyAdsManager.Instance.ShowBanner();
				}
			}else{
//				MyAdsManager.Instance.HideBanner();
				if(UIasdqqRoot!=null){
					UIasdqqRoot.SetActive(false);
				}
				boxEadsqxit.SetActive(true);
			}
		}
	}

	public void ClickSasdqetting(){
		//AudioManager.audioManager.PlaySingle(audioClip,false);
		if(cheadqck){
			iTween.MoveTo (groupSasdqetting, iTween.Hash ("position", new Vector3(-3.6f,0f,0), "time", 1, "easetype", iTween.EaseType.easeInOutBack));
			
			cheadqck=false;
		}else{
			iTween.MoveTo (groupSasdqetting, iTween.Hash ("position", new Vector3(-5f,0f,0), "time", 1, "easetype", iTween.EaseType.easeOutBack));
			cheadqck = true;
		}
	}

	public void SetLoaasdqdding(string level){
		//AudioManager.audioManager.PlaySingle(audioClip,false);
		loadasdqding.SetActive(true);
		loadasdqding.transform.GetChild(0).GetComponent<Loadding>().NameLoadLevel = level;
	}

	public void NextScasdqene(string nameScene){
		Application.LoadLevel(nameScene);

	}
	public void ClicasdqkButonPlay(){
		Invoke("Dasdqelay",.5f);
//		AudioManager.audioManager.PlaySingle(playAudio,false);
	}

	public void Dasdqelay(){
		Application.LoadLevel("ChooseLevel");
//		ManagerChooseLevel.check = true;
	}

//	public void NextSceneChooseLevel(string level){
//		Application.LoadLevel("ChooseLevel");
////		ManagerChooseLevel.check = false;
//		MyAdsManager.HideBanner();
//		for(int i=2;i<12;i++){
//			if(level=="Level"+i){
//				PlayerPrefs.SetInt("Level" + i,i);
//			}
//		}
//	}
	public void ChangasdqeMusic(){
		
		if (btnMusicasdq.transform.GetChild (0).gameObject.activeSelf == true) {
			btnMusicasdq.transform.GetChild (0).gameObject.SetActive (false);
			btnMusicasdq.transform.GetChild (1).gameObject.SetActive (true);
			AudioListener.pause = true;
//			MainStatic.CHECK_VOLUM= false;
		}else{
			btnMusicasdq.transform.GetChild (0).gameObject.SetActive (true);
			btnMusicasdq.transform.GetChild (1).gameObject.SetActive (false);
			AudioListener.pause = false;
//			MainStatic.CHECK_VOLUM= true;
		}
	}

	public void CliasdqckHome(){
		Application.LoadLevel("Home");
	}

	public void ClickasdqqYesExit(){
		Application.Quit();
	}
	public void CLickCanasdqqcelExit(){
//		MyAdsManager.Instance.ShowBanner();
		boxEadsqxit.SetActive(false);
	}

	public void ClickCanceasdqlNoBaweqwenner(){
		boxEadsqxit.SetActive(false);
	}
    
	public void ViweewsiblePanelqweqwe(){
		panasdqel.SetActive(false);
		butasdqwetonNext.SetActive(false);
//		AudioManager.audioManager.StopSingle(null);
	}

	public void ReplayqweqScene(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void EnebleqweqwePanel(){
		panasdqel.SetActive(true);
		butasdqwetonNext.SetActive(false);
//		AudioManager.audioManager.PlaySingle(playAudio,false);

	}

}
