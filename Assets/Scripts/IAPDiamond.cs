using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class IAPDiamond : MonoBehaviour {

	public void SetDsiamond(int numDiamond){
		PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + numDiamond);
		TextDiasdqamond.text = PlayerPrefs.GetInt("diamond") + "";
	}	public void SetDiaamond(int numDiamond){
		PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + numDiamond);
		TextDiasdqamond.text = PlayerPrefs.GetInt("diamond") + "";
	}	public void SetDiqweamond(int numDiamond){
		PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + numDiamond);
		TextDiasdqamond.text = PlayerPrefs.GetInt("diamond") + "";
	}
	[FormerlySerializedAs("TextDiamond")] public Text TextDiasdqamond;


	public void SetDiamond(int numDiamond){
		PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + numDiamond);
		TextDiasdqamond.text = PlayerPrefs.GetInt("diamond") + "";
	}
}
