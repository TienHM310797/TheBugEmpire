using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFollowLeaderControl : MonoBehaviour
{

    List<Transform> _fasdqish;
    public void FoasdqlalowStart()
    {
        _swasdqim = GetComponent<Swim>();
        _fasdqish = new List<Transform>();
        coasdquntFish = Random.Range(miasdqnCount, maasdqxCount);
        for (int i = 0; i < coasdquntFish; i++)
        {
            Transform _tr = Instantiate(_FishasdqPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Diasdqstan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowControl>().SetTasdqarget(transform, Vector3.Magnitude(transform.right * Diasdqstan * i));
            _tr.GetComponent<Swim>().Speeasdqd = _swasdqim.Speeasdqd;
            _fasdqish.Add(_tr);
        }
    }

    public void destrasdqoyOnwList(Transform _trs)
    {
        _fasdqish.Remove(_trs);

        if (_fasdqish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    int coasdquntFish = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FishasdqPre;
    [FormerlySerializedAs("Distan")] public float Diasdqstan = 0.5f;
    Swim _swasdqim;

    [FormerlySerializedAs("minCount")] public int miasdqnCount;
    [FormerlySerializedAs("maxCount")] public int maasdqxCount;

    public void FoasdqllowStart()
    {
        _swasdqim = GetComponent<Swim>();
        _fasdqish = new List<Transform>();
        coasdquntFish = Random.Range(miasdqnCount, maasdqxCount);
        for (int i = 0; i < coasdquntFish; i++)
        {
            Transform _tr = Instantiate(_FishasdqPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Diasdqstan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowControl>().SetTasdqarget(transform, Vector3.Magnitude(transform.right * Diasdqstan * i));
            _tr.GetComponent<Swim>().Speeasdqd = _swasdqim.Speeasdqd;
            _fasdqish.Add(_tr);
        }
    }

    public void destrasdqoyOnList(Transform _trs)
    {
        _fasdqish.Remove(_trs);

        if (_fasdqish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
