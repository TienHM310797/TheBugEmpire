using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus3Control : MonoBehaviour
{
    IEnumerator spaasdsqwm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prefaasdqb.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prefaasdqb.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prefaasdqb[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitasdqWith - 1 - _diasdqstance[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 + 90 - (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prefaasdqb.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prefaasdqb.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prefaasdqb[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitasdqWith + 1 + _diasdqstance[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90 + (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }

    [FormerlySerializedAs("_prefab")] public GameObject[] _prefaasdqb;
    [FormerlySerializedAs("_distance")] public float[] _diasdqstance;
    float limitHasdqieght;
    float limitasdqWith;

    void OnEnable()
    {
        limitHasdqieght = (Screen.height) / 200;
        limitasdqWith = (Screen.width) / 200;
        StartCoroutine(spaasdqwm());
    }

    IEnumerator spaasdqwm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prefaasdqb.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prefaasdqb.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prefaasdqb[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitasdqWith - 1 - _diasdqstance[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 + 90 - (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prefaasdqb.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)_prefaasdqb.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(_prefaasdqb[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitasdqWith + 1 + _diasdqstance[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90 + (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
