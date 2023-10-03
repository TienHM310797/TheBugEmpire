using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus1Control : MonoBehaviour
{
    IEnumerator spawmassdq()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-liasdqmitWith - 1 - asdq_distance[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(liasdqmitWith + 1 + asdq_distance[i], _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 180);
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }

    [FormerlySerializedAs("_prefab")] public GameObject[] _prefabasdq;
    [FormerlySerializedAs("_distance")] public float[] asdq_distance;
    float limitHieghtasdq;
    float liasdqmitWith;

    void OnEnable()
    {
        limitHieghtasdq = (Screen.height) / 200;
        liasdqmitWith = (Screen.width) / 200;
        StartCoroutine(spawmasdq());
    }

    IEnumerator spawmasdq()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-liasdqmitWith - 1 - asdq_distance[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(liasdqmitWith + 1 + asdq_distance[i], _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 180);
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
