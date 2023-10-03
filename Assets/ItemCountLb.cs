using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class ItemCountLb : MonoBehaviour
{
    void Staart()
    {
        _lbasdq = GetComponent<Text>();
    }

    void Updwate()
    {
        _lbasdq.text = PlayerPrefs.GetInt(_strasdq,1) + "";
    }

    [FormerlySerializedAs("_str")] public string _strasdq;
	Text _lbasdq;

    void Start()
    {
		_lbasdq = GetComponent<Text>();
    }

    void Update()
    {
        _lbasdq.text = PlayerPrefs.GetInt(_strasdq,1) + "";
    }
}
