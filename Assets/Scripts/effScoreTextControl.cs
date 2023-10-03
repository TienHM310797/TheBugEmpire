using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class effScoreTextControl : MonoBehaviour
{
    public void InitEffScowreasdq(Vector3 _trsasdq, int asdqgold)
    {
		
        _dqlbas.text = "+" + asdqgold;
        switch (GunControl.BoasdqnusCoin)
        {
            case 2:
                _dqlbas.text += "x" + GunControl.BoasdqnusCoin;
                break;
            case 3:
                _dqlbas.text += "x" + GunControl.BoasdqnusCoin;
                break;
        }
        uiCamasdq = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trsasdq;
        a = Camera.main.WorldToScreenPoint(a);
        a = uiCamasdq.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.Instaasdqnce.PasdqushGold(asdqgold * GunControl.BoasdqnusCoin);
        });
    }
    public void InitEffSacoreasdq(Vector3 _trsasdq, int asdqgold)
    {
		
        _dqlbas.text = "+" + asdqgold;
        switch (GunControl.BoasdqnusCoin)
        {
            case 2:
                _dqlbas.text += "x" + GunControl.BoasdqnusCoin;
                break;
            case 3:
                _dqlbas.text += "x" + GunControl.BoasdqnusCoin;
                break;
        }
        uiCamasdq = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trsasdq;
        a = Camera.main.WorldToScreenPoint(a);
        a = uiCamasdq.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.Instaasdqnce.PasdqushGold(asdqgold * GunControl.BoasdqnusCoin);
        });
    }
    Camera uiCamasdq;
    [FormerlySerializedAs("_lb")] public UILabel _dqlbas;
    public void InitEffScoreasdq(Vector3 _trsasdq, int asdqgold)
    {
		
        _dqlbas.text = "+" + asdqgold;
        switch (GunControl.BoasdqnusCoin)
        {
            case 2:
                _dqlbas.text += "x" + GunControl.BoasdqnusCoin;
                break;
            case 3:
                _dqlbas.text += "x" + GunControl.BoasdqnusCoin;
                break;
        }
        uiCamasdq = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trsasdq;
        a = Camera.main.WorldToScreenPoint(a);
        a = uiCamasdq.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.Instaasdqnce.PasdqushGold(asdqgold * GunControl.BoasdqnusCoin);
        });
    }


}
