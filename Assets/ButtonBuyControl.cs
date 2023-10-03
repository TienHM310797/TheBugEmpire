using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class ButtonBuyControl : MonoBehaviour
{
    public void Clickassdq()
    {
        if (PlayerPrefs.GetInt("diamond") >= priasdqce)
        {
            PlayerPrefs.SetInt(_strasdq, PlayerPrefs.GetInt(_strasdq,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - priasdqce);
            if (_txtasdq != null)
            {
                _txtasdq.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            popUpasdq.SetActive(true);
            Shopasdq.SetActive(false);
        }
    }
    public void Clickqasdq()
    {
        if (PlayerPrefs.GetInt("diamond") >= priasdqce)
        {
            PlayerPrefs.SetInt(_strasdq, PlayerPrefs.GetInt(_strasdq,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - priasdqce);
            if (_txtasdq != null)
            {
                _txtasdq.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            popUpasdq.SetActive(true);
            Shopasdq.SetActive(false);
        }
    }

    [FormerlySerializedAs("_str")] public string _strasdq;
    [FormerlySerializedAs("price")] public int priasdqce;
	[FormerlySerializedAs("priceLb")] public Text asdq;
    [FormerlySerializedAs("popUp")] public GameObject popUpasdq;
	[FormerlySerializedAs("Shop")] public GameObject Shopasdq;
	[FormerlySerializedAs("_txt")] public Text _txtasdq;

    public void Clickasdq()
    {
        if (PlayerPrefs.GetInt("diamond") >= priasdqce)
        {
            PlayerPrefs.SetInt(_strasdq, PlayerPrefs.GetInt(_strasdq,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - priasdqce);
            if (_txtasdq != null)
            {
                _txtasdq.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            popUpasdq.SetActive(true);
			Shopasdq.SetActive(false);
        }
    }

}
