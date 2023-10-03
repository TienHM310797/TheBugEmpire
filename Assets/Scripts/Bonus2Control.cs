using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus2Control : MonoBehaviour {

    IEnumerator spawassdqm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limasdqitWith - 1 - _distasdqance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 +90- (90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limasdqitWith + 1 + _distasdqance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90+(90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
    [FormerlySerializedAs("_prefab")] public GameObject[] _prefabasdq;
    [FormerlySerializedAs("_distance")] public float[] _distasdqance;
    float limitasdqHieght;
    float limasdqitWith;

    void OnEnable()
    {
        limitasdqHieght = (Screen.height) / 200;
        limasdqitWith = (Screen.width) / 200;
        StartCoroutine(spawasdqm());
    }

    IEnumerator spawasdqm()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limasdqitWith - 1 - _distasdqance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 +90- (90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < _prefabasdq.Length; i++)
                {
                    Transform _tr = Instantiate(_prefabasdq[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limasdqitWith + 1 + _distasdqance[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90+(90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FolloasdqwStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
