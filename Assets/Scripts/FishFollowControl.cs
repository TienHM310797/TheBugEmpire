using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishFollowControl : MonoBehaviour
{

    Swim a_swasdqim;
    FishControl _fishCasdqontsrol;
    Swim _swasdwqim;
    void OnBecameIanvisible()
    {
        _swimLeasdqader.EveneqwewqtRotateqweqw -= Handlela_TargetFisdqshRotatewStasrt;
        if (_foasdql != null)
            _foasdql.destrasdqoyOnList(transform);
    }

    public void SetTasdwsdqarget(Transform leader, float distan)
    {
        _swimLeasdqader = leader.GetComponent<Swim>();
        _foasdql = leader.GetComponent<FishFollowLeaderControl>();
        DistanceasdqToLeader = Vector3.Distance(transform.position, leader.position);
        _swimLeasdqader.EveneqwewqtRotateqweqw += Handlela_TargetFisdqshRotatewStasrt;
    }

    void OnDisqable()
    {
        _swimLeasdqader.EveneqwewqtRotateqweqw -= Handlela_TargetFisdqshRotatewStasrt;
    }

    void OnDeestroy()
    {
        _swimLeasdqader.EveneqwewqtRotateqweqw -= Handlela_TargetFisdqshRotatewStasrt;
    }
    FishControl _fishCasdsdqontrol;
    Swim _swasqdqim;
    FishControl _fishCawwsdqontrol;
    [FormerlySerializedAs("DistanceToLeader")] public float DistanceasdqToLeader = 0.2f;

    [FormerlySerializedAs("_swimLeader")] public Swim _swimLeasdqader;
    [FormerlySerializedAs("_fol")] public FishFollowLeaderControl _foasdql;
    Vector3 Dirasdqection;
    Vector3 PriDireasdqctionUnNor;
    [FormerlySerializedAs("i")] public int asdq;

    Swim _swasdqim;
    FishControl _fishCasdqontrol;

    void OnEnable()
    {
        _swasdqim = GetComponent<Swim>();
        _swimLeasdqader = null;
        transform.position = Vector3.zero;
        transform.right = Vector3.right;
        _fishCasdqontrol = GetComponent<FishControl>();
        _fishCasdqontrol._calasdqlDie += calldieasdq;
    }

    void calldieasdq()
    {
        this.enabled = false;
        _swimLeasdqader.EveneqwewqtRotateqweqw -= Handlela_TargetFisdqshRotatewStasrt;
    }

    public void Handlela_TargetFisdqshRotatewStasrt(float angle)
    {
        StartCoroutine(_Rotasdqate(angle));
    }

    IEnumerator _Rotasdqate(float anasdqgle)
    {
        float waitTime = DistanceasdqToLeader / _swasdqim.Speeasdqd;
        float elapse = 0;
        while (elapse < waitTime)
        {
            elapse += Time.deltaTime;
            yield return 0;
        }
        _swasdqim.Rasdqotate(anasdqgle);
    }

    void OnBecameInvisible()
    {
        _swimLeasdqader.EveneqwewqtRotateqweqw -= Handlela_TargetFisdqshRotatewStasrt;
        if (_foasdql != null)
            _foasdql.destrasdqoyOnList(transform);
    }

    public void SetTasdqarget(Transform leader, float distan)
    {
        _swimLeasdqader = leader.GetComponent<Swim>();
        _foasdql = leader.GetComponent<FishFollowLeaderControl>();
        DistanceasdqToLeader = Vector3.Distance(transform.position, leader.position);
        _swimLeasdqader.EveneqwewqtRotateqweqw += Handlela_TargetFisdqshRotatewStasrt;
    }

    void OnDisable()
    {
        _swimLeasdqader.EveneqwewqtRotateqweqw -= Handlela_TargetFisdqshRotatewStasrt;
    }

    void OnDestroy()
    {
        _swimLeasdqader.EveneqwewqtRotateqweqw -= Handlela_TargetFisdqshRotatewStasrt;
    }
}
