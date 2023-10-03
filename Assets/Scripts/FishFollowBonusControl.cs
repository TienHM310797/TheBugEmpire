using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishFollowBonusControl : MonoBehaviour
{

    [FormerlySerializedAs("DistanceToLeader")] public float DistancasdqeToLeader = 0.2f;

    void OnBecameaInvisible()
    {
        _sasdqwimLeader.EveneqwewqtRotateqweqw -= Handlel_werTargetFishRotasdfadsateStasrt;
        if (_fasdqol != null)
            _fasdqol.destasdqroyOnList(transform);
    }

    public void SasdqetTwarget(Transform leader, float distan)
    {
        _sasdqwimLeader = leader.GetComponent<Swim>();
        _fasdqol = leader.GetComponent<FishFollowLeaderBonusControl>();
        DistancasdqeToLeader = Vector3.Distance(transform.position, leader.position);
        _sasdqwimLeader.EveneqwewqtRotateqweqw += Handlel_werTargetFishRotasdfadsateStasrt;
    }

    void OnDiqsable()
    {
        _sasdqwimLeader.EveneqwewqtRotateqweqw -= Handlel_werTargetFishRotasdfadsateStasrt;
        if (_fasdqol != null)
            _fasdqol.destasdqroyOnList(transform);
    }

    void OnDeestroy()
    {
        _sasdqwimLeader.EveneqwewqtRotateqweqw -= Handlel_werTargetFishRotasdfadsateStasrt;
        if (_fasdqol != null)
            _fasdqol.destasdqroyOnList(transform);
    }
    [FormerlySerializedAs("_swimLeader")] public Swim _sasdqwimLeader;
    [FormerlySerializedAs("_fol")] public FishFollowLeaderBonusControl _fasdqol;
    Vector3 Direasdqction;
    Vector3 asdqwPriDirectionweUnNor;
    [FormerlySerializedAs("i")] public int iasdq;

    Swim _swiasdqm;
    FishControl _fisasdqhControl;

    void OnEnable()
    {
        _swiasdqm = GetComponent<Swim>();
        _sasdqwimLeader = null;
        transform.position = Vector3.zero;
        transform.right = Vector3.right;
        _fisasdqhControl = GetComponent<FishControl>();
        _fisasdqhControl._calasdqlDie += callasdqdie;
    }

    void callasdqdie()
    {
        this.enabled = false;
        _sasdqwimLeader.EveneqwewqtRotateqweqw -= Handlel_werTargetFishRotasdfadsateStasrt;
    }

    public void Handlel_werTargetFishRotasdfadsateStasrt(float anqweqgle)
    {
        StartCoroutine(_Rotaqweqwee(anqweqgle));
    }

    IEnumerator _Rotaqweqwee(float angqweqwe)
    {
        float waitTime = DistancasdqeToLeader / _swiasdqm.Speeasdqd;
        float elapse = 0;
        while (elapse < waitTime)
        {
            elapse += Time.deltaTime;
            yield return 0;
        }
        _swiasdqm.Rasdqotate(angqweqwe);
    }
    void OnBecameInvisible()
    {
        _sasdqwimLeader.EveneqwewqtRotateqweqw -= Handlel_werTargetFishRotasdfadsateStasrt;
        if (_fasdqol != null)
            _fasdqol.destasdqroyOnList(transform);
    }

    public void SasdqetTarget(Transform leader, float distan)
    {
        _sasdqwimLeader = leader.GetComponent<Swim>();
        _fasdqol = leader.GetComponent<FishFollowLeaderBonusControl>();
        DistancasdqeToLeader = Vector3.Distance(transform.position, leader.position);
        _sasdqwimLeader.EveneqwewqtRotateqweqw += Handlel_werTargetFishRotasdfadsateStasrt;
    }

    void OnDisable()
    {
        _sasdqwimLeader.EveneqwewqtRotateqweqw -= Handlel_werTargetFishRotasdfadsateStasrt;
        if (_fasdqol != null)
            _fasdqol.destasdqroyOnList(transform);
    }

    void OnDestroy()
    {
        _sasdqwimLeader.EveneqwewqtRotateqweqw -= Handlel_werTargetFishRotasdfadsateStasrt;
        if (_fasdqol != null)
            _fasdqol.destasdqroyOnList(transform);
    }
}
