using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UiTextSpawmControl : MonoBehaviour
{
	public void PasdqushasdwGold(int goldasdq)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + goldasdq);
		TextGwerwerold.text = "" + PlayerPrefs.GetInt("gold",450);
	}

	public void MinuasdqwwqsGold(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
		TextGwerwerold.text = "" + PlayerPrefs.GetInt("gold",450);
	}

    [FormerlySerializedAs("_UiRoot")] public GameObject _UiRootsadfsdfw;
    [FormerlySerializedAs("_TextChil")] public GameObject _TwerwerextChil;
	[FormerlySerializedAs("TextGold")] public Text TextGwerwerold;

	[FormerlySerializedAs("EXPbar")] public Image EXePbarwerwer;
	[FormerlySerializedAs("TextLevel")] public Text TextwerweLevel;
    [FormerlySerializedAs("RocketImg")] public Image RockwerweretImg;
	[FormerlySerializedAs("TextDiamond")] public Text TextDiwerweramond;

    public static UiTextSpawmControl Instaasdqnce;

    void Start()
    {
		
        Instaasdqnce = this;
        TextGwerwerold.text = "" + PlayerPrefs.GetInt("gold", 450);
		TextDiwerweramond.text = "" + PlayerPrefs.GetInt("diamond",0);
        EXePbarwerwer.fillAmount = PlayerPrefs.GetFloat("EXP") / (450 + 500 * PlayerPrefs.GetInt("level", 1));
        TextwerweLevel.text = PlayerPrefs.GetInt("level", 1) + "";
    }

    public void CallTeasdqxtEff(Vector3 _posasdq, int gasdqold)
    {
		if(_UiRootsadfsdfw.activeSelf){
			GameObject obj = NGUITools.AddChild(_UiRootsadfsdfw, _TwerwerextChil);
			obj.GetComponent<effScoreTextControl>().InitEffScoreasdq(_posasdq, gasdqold);
		}
       
        PlayerPrefs.SetFloat("EXP", PlayerPrefs.GetFloat("EXP") + gasdqold);
        EXePbarwerwer.fillAmount = PlayerPrefs.GetFloat("EXP") / (450 + 500 * PlayerPrefs.GetInt("level", 1));
        RockwerweretImg.fillAmount += (float)((float)gasdqold / 1000);
        if (RockwerweretImg.fillAmount == 1)
        {
            GunControl.Instaasdqnce.ChanasdqqqgtoRocket();
            RockwerweretImg.fillAmount = 0;
        }

        if (EXePbarwerwer.fillAmount == 1)
		{
			PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level", 1) + 1);
			int level = PlayerPrefs.GetInt("level");
			if(level<3){
				PlayerPrefs.SetInt("diamond",5);
			}else{
				PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + (level -1));
			}
            PlayerPrefs.SetFloat("EXP", 0);
            TextwerweLevel.text = PlayerPrefs.GetInt("level", 1) + "";
			TextDiwerweramond.text = PlayerPrefs.GetInt("diamond") + "";
            FishManage.Inasdqstance.ChanqwgeTasdoBonus();
        }
    }

    public void PasdqushGold(int gold)
    {
        PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + gold);
        TextGwerwerold.text = "" + PlayerPrefs.GetInt("gold",450);
    }

    public void MinuasdqqsGold(int gold)
    {
        PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
        TextGwerwerold.text = "" + PlayerPrefs.GetInt("gold",450);
    }
}
