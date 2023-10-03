using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishSwimBonus4 : MonoBehaviour
{

    public void asdqBonaus4(float index, float direction)
    {
        _swimasdq = GetComponent<Swim>();
        _swimasdq.Speeasdqd = ((Mathf.PI * index) / 5);
        _swimasdq.RotatasdqeSpeed = 38;
        _asdqfish = new List<Transform>();
        for (int i = 0; i < asdqwed; i++)
        {
            Transform _tr = Instantiate(_FishasdqPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distanasdq * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SasdqetTarget(transform, Vector3.Magnitude(transform.right * Distanasdq * i));
            _tr.GetComponent<Swim>().Speeasdqd = _swimasdq.Speeasdqd;
            _tr.GetComponent<Swim>().RotatasdqeSpeed = 38;
            if (direction == 0)
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdfw = 270;
            else
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdfw = 90;
            _asdqfish.Add(_tr);
        }
        Destroy(gameObject);
    }

    void Updawte()
    {
        // transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, 270), 180 * Time.deltaTime / 5);
    }

    public void destrqoyOnList(Transform _trsasdq)
    {
        _asdqfish.Remove(_trsasdq);

        if (_asdqfish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    Swim _swimasdq;

    List<Transform> _asdqfish;
    [FormerlySerializedAs("countFish")] public int asdqwed = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FishasdqPre;
    [FormerlySerializedAs("Distan")] public float Distanasdq = 0.5f;

    public void asdqBonus4(float indasdqex, float asdqw)
    {
        _swimasdq = GetComponent<Swim>();
        _swimasdq.Speeasdqd = ((Mathf.PI * indasdqex) / 5);
        _swimasdq.RotatasdqeSpeed = 38;
        _asdqfish = new List<Transform>();
        for (int i = 0; i < asdqwed; i++)
        {
            Transform _tr = Instantiate(_FishasdqPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distanasdq * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SasdqetTarget(transform, Vector3.Magnitude(transform.right * Distanasdq * i));
            _tr.GetComponent<Swim>().Speeasdqd = _swimasdq.Speeasdqd;
            _tr.GetComponent<Swim>().RotatasdqeSpeed = 38;
            if (asdqw == 0)
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdfw = 270;
            else
                _tr.gameObject.AddComponent<SwinRotationBonus>().asdfw = 90;
            _asdqfish.Add(_tr);
        }
        Destroy(gameObject);
    }

    void Update()
    {
        // transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, 270), 180 * Time.deltaTime / 5);
    }

    public void destroyOnList(Transform _trs)
    {
        _asdqfish.Remove(_trs);

        if (_asdqfish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
