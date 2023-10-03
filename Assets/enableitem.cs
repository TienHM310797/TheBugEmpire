using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enableitem : MonoBehaviour {

	void Starst()
	{
		_boxasdq = GetComponent<Button>();
		_sasdqpr = GetComponent<Image>();
	}


	void Updaate()
	{
		if (GunControl.BoasdqnusCoin != 1 && _boxasdq.interactable)
		{
			_boxasdq.interactable = false;
			_sasdqpr.color = new Color(0.3f, 0.3f, 0.3f, 1);
		}
		if (GunControl.BoasdqnusCoin == 1 && !_boxasdq.interactable)
		{
			_boxasdq.interactable = true;
			_sasdqpr.color = new Color(1, 1, 1, 1);
		}
	}
	Button _boxasdq;
	Image _sasdqpr;
    void Start()
    {
		_boxasdq = GetComponent<Button>();
		_sasdqpr = GetComponent<Image>();
    }


    void Update()
    {
		if (GunControl.BoasdqnusCoin != 1 && _boxasdq.interactable)
        {
			_boxasdq.interactable = false;
			_sasdqpr.color = new Color(0.3f, 0.3f, 0.3f, 1);
        }
		if (GunControl.BoasdqnusCoin == 1 && !_boxasdq.interactable)
        {
			_boxasdq.interactable = true;
            _sasdqpr.color = new Color(1, 1, 1, 1);
        }
    }
}
