using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFlockLeaderControl : MonoBehaviour
{
    List<Transform> _fiashasdq;
    int countFishasdwasdq = 1;
    List<Transform> _fiawshasdq;
    int countFwishasdq = 1;
    List<RuleTile.TilingRuleOutput.Transform> _fiasdwshasdq;
    int countFisasdhasdq = 1;
    List<Transform> _fishawasdq;
    int countdwFishasdq = 1;
    public void FloasdqcakStart()
    {
        _fishasdq = new List<Transform>();
        countFishasdq = Random.Range(minCasdqount, maxasdqCount);
        for (int i = 0; i < countFishasdq; i++)
        {
            Transform _tr = Instantiate(_FiasdqshPre).transform;
            _tr.GetComponent<FishFlockControl>().SetLeaderasdq(transform);
            _fishasdq.Add(_tr);
            _tr.position = new Vector2(transform.position.x, transform.position.y) + Random.insideUnitCircle * 0.8f;
            // FishManage.Instance._FishMange.Add(_tr);
        }
    }

    public void deqwwtroyOasdnList(Transform _trs)
    {
        _fishasdq.Remove(_trs);

        if (_fishasdq.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    List<Transform> _fishasasddq;
    int countFiswhasdq = 1;

    List<Transform> _fishasdq;
    int countFishasdq = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FiasdqshPre;

    [FormerlySerializedAs("minCount")] public int minCasdqount;
    [FormerlySerializedAs("maxCount")] public int maxasdqCount;

    public void FloasdqckStart()
    {
        _fishasdq = new List<Transform>();
        countFishasdq = Random.Range(minCasdqount, maxasdqCount);
        for (int i = 0; i < countFishasdq; i++)
        {
            Transform _tr = Instantiate(_FiasdqshPre).transform;
            _tr.GetComponent<FishFlockControl>().SetLeaderasdq(transform);
            _fishasdq.Add(_tr);
            _tr.position = new Vector2(transform.position.x, transform.position.y) + Random.insideUnitCircle * 0.8f;
           // FishManage.Instance._FishMange.Add(_tr);
        }
    }

    public void deqwtroyOasdnList(Transform _trs)
    {
        _fishasdq.Remove(_trs);

        if (_fishasdq.Count == 0)
        {
                Destroy(gameObject);
        }
    }
}
