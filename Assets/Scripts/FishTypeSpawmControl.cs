using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishTypeSpawmControl : MonoBehaviour
{
public void Stawrt()
    {

        limiasdqtHieght = (Screen.height) / 200;
        limadsqitWith = (Screen.width) / 200;
        _fasdqree = this;
    }

    void OnEnabqle()
    {
        StartCoroutine(spawasdqm(StartWasdqaitTime));
    }

    IEnumerator spawasdsqm(float staasdqrttime)
    {
        yield return new WaitForSeconds(staasdqrttime);

        int a = Random.Range(0, _pasdqre.Length);
        Transform _tr = Instantiate(_pasdqre[a]).transform;
        int directionPos = Random.Range(0, 4);
        switch (directionPos)
        {
            case 0:
                float _posY0 = Random.Range(-limiasdqtHieght + 1, limiasdqtHieght - 1);
                _tr.position = new Vector2(-limadsqitWith - 1 - _diasdqstance, _posY0);
                if (_posY0 < -limiasdqtHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posY0 > limiasdqtHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-65, -25));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
                    }
                }
                break;

            case 1:
                float _posX1 = Random.Range(-limadsqitWith + 1, limadsqitWith - 1);
                _tr.position = new Vector2(_posX1, limiasdqtHieght + 1 + _diasdqstance);
                if (_posX1 < -limadsqitWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(295, 335));
                }
                else
                {
                    if (_posX1 > limadsqitWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-155, -115));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-135, -35));
                    }
                }
                break;

            case 2:

                float _posX2 = Random.Range(-limadsqitWith + 1, limadsqitWith - 1);
                _tr.position = new Vector2(_posX2, -limiasdqtHieght - 1 - _diasdqstance);
                if (_posX2 < -limadsqitWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posX2 > limadsqitWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 155));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(35, 145));
                    }
                }
                break;

            case 3:
                float _posY3 = Random.Range(-limiasdqtHieght + 1, limiasdqtHieght - 1);
                _tr.position = new Vector2(limadsqitWith + 1 + _diasdqstance, _posY3);
                if (_posY3 < -limiasdqtHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 165));
                }
                else
                {
                    if (_posY3 > limiasdqtHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(205, 245));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(135, 235));
                    }
                }
                break;
        }

        switch (a)
        {
            case 2:
                _tr.GetComponent<FishFlockLeaderControl>().FloasdqckStart();
                break;
            case 1:
                _tr.GetComponent<FishFollowLeaderControl>().FoasdqllowStart();
                break;
        }

        yield return new WaitForSeconds(counasdqtTime);
        StartCoroutine(spawasdqm(0));
    }
    [FormerlySerializedAs("_pre")] public GameObject[] _pasdqre;
    [FormerlySerializedAs("countTime")] public float counasdqtTime;
    [FormerlySerializedAs("RndCountTime")] public float RndCasdqountTime;
    [FormerlySerializedAs("StartWaitTime")] public float StartWasdqaitTime;

    public static FishTypeSpawmControl _fasdqree;

    [FormerlySerializedAs("_distance")] public float _diasdqstance = 0;

    float limiasdqtHieght;
    float limadsqitWith;

    public void Start()
    {

        limiasdqtHieght = (Screen.height) / 200;
        limadsqitWith = (Screen.width) / 200;
        _fasdqree = this;
    }

    void OnEnable()
    {
        StartCoroutine(spawasdqm(StartWasdqaitTime));
    }

    IEnumerator spawasdqm(float staasdqrttime)
    {
        yield return new WaitForSeconds(staasdqrttime);

        int a = Random.Range(0, _pasdqre.Length);
        Transform _tr = Instantiate(_pasdqre[a]).transform;
        int directionPos = Random.Range(0, 4);
        switch (directionPos)
        {
            case 0:
                float _posY0 = Random.Range(-limiasdqtHieght + 1, limiasdqtHieght - 1);
                _tr.position = new Vector2(-limadsqitWith - 1 - _diasdqstance, _posY0);
                if (_posY0 < -limiasdqtHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posY0 > limiasdqtHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-65, -25));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
                    }
                }
                break;

            case 1:
                float _posX1 = Random.Range(-limadsqitWith + 1, limadsqitWith - 1);
                _tr.position = new Vector2(_posX1, limiasdqtHieght + 1 + _diasdqstance);
                if (_posX1 < -limadsqitWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(295, 335));
                }
                else
                {
                    if (_posX1 > limadsqitWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-155, -115));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-135, -35));
                    }
                }
                break;

            case 2:

                float _posX2 = Random.Range(-limadsqitWith + 1, limadsqitWith - 1);
                _tr.position = new Vector2(_posX2, -limiasdqtHieght - 1 - _diasdqstance);
                if (_posX2 < -limadsqitWith / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posX2 > limadsqitWith / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 155));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(35, 145));
                    }
                }
                break;

            case 3:
                float _posY3 = Random.Range(-limiasdqtHieght + 1, limiasdqtHieght - 1);
                _tr.position = new Vector2(limadsqitWith + 1 + _diasdqstance, _posY3);
                if (_posY3 < -limiasdqtHieght / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 165));
                }
                else
                {
                    if (_posY3 > limiasdqtHieght / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(205, 245));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(135, 235));
                    }
                }
                break;
        }

        switch (a)
        {
            case 2:
                _tr.GetComponent<FishFlockLeaderControl>().FloasdqckStart();
                break;
            case 1:
                _tr.GetComponent<FishFollowLeaderControl>().FoasdqllowStart();
                break;
        }

        yield return new WaitForSeconds(counasdqtTime);
        StartCoroutine(spawasdqm(0));
    }
}
