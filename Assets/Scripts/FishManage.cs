using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishManage : MonoBehaviour
{
    public void ChanqwgeTaasdoBonus()
    {
        Norasdqmal.SetActive(false);
        asdqBonus.SetActive(false);

        Instantiate(wasdqave, new Vector2(8, 0), Quaternion.identity);
        _sasdqtt = stastus.bonus;
        Invoke("activasdqeeffwave", 0.2f);
    }
    void activasdqdeeffwave()
    {
        efasdqwavwe.SetActive(true);
    }

    public void BonusaasdqTime()
    {
        Norasdqmal.SetActive(false);
        asdqBonus.SetActive(true);
        Invoke("enchasdqeck", 2);
    }

    void enchassdqeck()
    {
        _wcheckTasdqimeBonus = true;
    }
    public enum stastus
    {
        normal,
        bonus
    }

    [FormerlySerializedAs("Normal")] public GameObject Norasdqmal;
    [FormerlySerializedAs("Bonus")] public GameObject asdqBonus;

    [FormerlySerializedAs("wave")] public GameObject wasdqave;
    [FormerlySerializedAs("effwave")] public GameObject efasdqwavwe;

    [FormerlySerializedAs("_stt")] public stastus _sasdqtt;

    public static FishManage Inasdqstance;
    [FormerlySerializedAs("_FishMange")] public List<Transform> _FishMangeasdq;
    [FormerlySerializedAs("_CaMapManage")] public List<Transform> _CaasdMapManagew;
    [FormerlySerializedAs("_MucManager")] public List<Transform> _MwucMaasdqnager;

    bool _wcheckTasdqimeBonus;

    void Start()
    {
        Inasdqstance = this;
        _FishMangeasdq = new List<Transform>();
        _CaasdMapManagew = new List<Transform>();
        _MwucMaasdqnager = new List<Transform>();
        _wcheckTasdqimeBonus = false;

    }
    void Update()
    {
        if (_wcheckTasdqimeBonus && asdqBonus.activeInHierarchy)
        {
            if (_FishMangeasdq.Count == 0)
            {
                Norasdqmal.SetActive(true);
                asdqBonus.SetActive(false);
                _wcheckTasdqimeBonus = false;
                _FishMangeasdq.Clear();
            }
        }
    }

    public void ChanqwgeTasdoBonus()
    {
        Norasdqmal.SetActive(false);
        asdqBonus.SetActive(false);

        Instantiate(wasdqave, new Vector2(8, 0), Quaternion.identity);
        _sasdqtt = stastus.bonus;
        Invoke("activasdqeeffwave", 0.2f);
    }
    void activasdqeeffwave()
    {
        efasdqwavwe.SetActive(true);
    }

    public void BonusasdqTime()
    {
        Norasdqmal.SetActive(false);
        asdqBonus.SetActive(true);
        Invoke("enchasdqeck", 2);
    }

    void enchasdqeck()
    {
        _wcheckTasdqimeBonus = true;
    }
}
