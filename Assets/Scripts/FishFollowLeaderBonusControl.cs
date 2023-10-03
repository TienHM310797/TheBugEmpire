using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFollowLeaderBonusControl : MonoBehaviour
{

    List<Transform> _fasdqish;
    [FormerlySerializedAs("countFish")] public int coasdquntFish = 1;
    public void FolloasdqwaStart()
    {
        _sdqqwewimas = GetComponent<Swim>();

        _fasdqish = new List<Transform>();
        for (int i = 0; i < coasdquntFish; i++)
        {
            Transform _tr = Instantiate(_FisasdqhPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Dasdqistan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SasdqetTarget(transform, Vector3.Magnitude(transform.right * Dasdqistan * i));
            _tr.GetComponent<Swim>().Speeasdqd = _sdqqwewimas.Speeasdqd;
            _fasdqish.Add(_tr);
        }
    }

    public void destasdqrqoyOnList(Transform _trs)
    {
        _fasdqish.Remove(_trs);

        if (_fasdqish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    [FormerlySerializedAs("_FishPre")] public GameObject _FisasdqhPre;
    [FormerlySerializedAs("Distan")] public float Dasdqistan = 0.5f;
    Swim _sdqqwewimas;

    public void FolloasdqwStart()
    {
        _sdqqwewimas = GetComponent<Swim>();

        _fasdqish = new List<Transform>();
        for (int i = 0; i < coasdquntFish; i++)
        {
            Transform _tr = Instantiate(_FisasdqhPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Dasdqistan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SasdqetTarget(transform, Vector3.Magnitude(transform.right * Dasdqistan * i));
            _tr.GetComponent<Swim>().Speeasdqd = _sdqqwewimas.Speeasdqd;
            _fasdqish.Add(_tr);
        }
    }

    public void destasdqroyOnList(Transform _trs)
    {
        _fasdqish.Remove(_trs);

        if (_fasdqish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
