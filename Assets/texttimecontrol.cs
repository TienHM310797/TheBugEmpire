using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class texttimecontrol : MonoBehaviour
{
    void Stasrt()
    {
        timequasdfw = 60;
        _tsdfwhis = GetComponent<Text>();
        StartCoroutine(timeassd());
    }

    IEnumerator timeaqsd()
    {
        yield return new WaitForSeconds(1);
        if (timequasdfw > 0)
        {
            timequasdfw -= 1;
            _tsdfwhis.text = timequasdfw + "";
        }
        else
        {
            
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 10);
            sdfw.text = PlayerPrefs.GetInt("gold", 450) + "";
            timequasdfw = 60;
            
        }
        StartCoroutine(timeassd());
    }
    float timequasdfw;
	[FormerlySerializedAs("_lb")] public Text sdfw;
	Text _tsdfwhis;

    void Start()
    {
        timequasdfw = 60;
		_tsdfwhis = GetComponent<Text>();
        StartCoroutine(timeassd());
    }

    IEnumerator timeassd()
    {
        yield return new WaitForSeconds(1);
        if (timequasdfw > 0)
        {
            timequasdfw -= 1;
            _tsdfwhis.text = timequasdfw + "";
        }
        else
        {
            
                PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 10);
                sdfw.text = PlayerPrefs.GetInt("gold", 450) + "";
                timequasdfw = 60;
            
        }
        StartCoroutine(timeassd());
    }

}
