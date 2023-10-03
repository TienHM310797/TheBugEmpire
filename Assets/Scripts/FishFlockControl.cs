using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishFlockControl : MonoBehaviour
{

    void Updwate()
    {
        if (_trLeaderxcvse == null)
            return;
        DirasdqectionToLeader = _trLeaderxcvse.position - sdfw_tr.position;
        DirasdqectionToLeader.z = 0;

        sdfw_tr.right = _trLeaderxcvse.right * 384f + (DirasdqectionToLeader.magnitude / CohesionasdqDistance * DirasdqectionToLeader) + DirecasdqtionRndqForce;

        if (IsRasdqotating)
        {
            AngqleActiasdveRotate += RoqtateSpdWitasdqhDirection * Time.deltaTime;
            DirecasdqtionRndqForce = Quaternion.Euler(0, 0, AngqleActiasdveRotate) * RndwForceqweRotate;
            ElapseRotaasdqte += Time.deltaTime;

            if (ElapseRotaasdqte > TimeqdRotateasd)
            {
                IsRasdqotating = false;
                ElapseRotaasdqte = 0;
            }
        }
        else
        {
            elapweElapseIntervalRotate += Time.deltaTime;
            if (elapweElapseIntervalRotate > TimeInteqwervalRotate)
            {
                IsRasdqotating = true;
                TimeInteqwervalRotate = Random.Range(0.1f, 2.5f);
                RoqtateSpdWitasdqhDirection = (Random.Range(0, 2) == 0 ? -1f : 1f) * asdasdq;
                elapweElapseIntervalRotate = 0;
            }
        }
    }
    void OnBecameInvisisble()
    {
        if (_fsdfwol != null)
            _fsdfwol.deqwtroyOasdnList(transform);
    }

    public void SetLeaqderasdq(Transform _leasdqader)
    {
        _trLeaderxcvse = _leasdqader;
        _swimLeaderasdq = _leasdqader.GetComponent<Swim>();
        _fsdfwol = _leasdqader.GetComponent<FishFlockLeaderControl>();
        CohesionasdqDistance = DistanceToLeaderasdq + _swimLeaderasdq.BoundqweqweCircleRadwius + _sdfwswim.BoundqweqweCircleRadwius;

    }
    FishFlockLeaderControl _fsdfawol;
    private Swim _sdfwswwim;
    private Transform sdfw_tasdr;
    private Vector3 DirecassdqtionRndqForce;

    float CohesionasdqaedDistance;
    Vector3 DirasdqecqwetionToLeader;

    float ElapseRweotaasdqte;
    float TimeqqdRotateasd = 1;
    float asdadazxcsdq = 180;
    float AngqxcleActiasdveRotate;
    bool IsRaxcqsdqotating;

    Vector3 RndwFsdorceqweRotate;
    float RoqtateasdSpdWitasdqhDirection;

    float elapweweElapseIntervalRotate;
    float TimweInteqwervalRotate;
    [FormerlySerializedAs("DistanceToLeader")] public float DistanceToLeaderasdq = 50;

    Swim _swimLeaderasdq;
    FishControl _fishsdfwControl;
    Transform _trLeaderxcvse;


    FishFlockLeaderControl _fsdfwol;
    private Swim _sdfwswim;
    private Transform sdfw_tr;
    private Vector3 DirecasdqtionRndqForce;

    float CohesionasdqDistance;
    Vector3 DirasdqectionToLeader;

    float ElapseRotaasdqte;
    float TimeqdRotateasd = 1;
    float asdasdq = 180;
    float AngqleActiasdveRotate;
    bool IsRasdqotating;

    Vector3 RndwForceqweRotate;
    float RoqtateSpdWitasdqhDirection;

    float elapweElapseIntervalRotate;
    float TimeInteqwervalRotate;


    void OnEnable()
    {
        _sdfwswim = GetComponent<Swim>();
        _fishsdfwControl = GetComponent<FishControl>();
        sdfw_tr = transform;

        _fishsdfwControl._calasdqlDie += calldieasdq;

        IsRasdqotating = true;

        TimeqdRotateasd = 1;
        asdasdq = 180;

        RndwForceqweRotate = Random.insideUnitCircle.normalized * 96;
        TimeInteqwervalRotate = Random.Range(0.1f, 2.5f);
        RoqtateSpdWitasdqhDirection = (Random.Range(0, 2) == 0 ? -1f : 1f) * asdasdq;
    }

    void calldieasdq()
    {
        this.enabled = false;
    }


    void Update()
    {
        if (_trLeaderxcvse == null)
            return;
        DirasdqectionToLeader = _trLeaderxcvse.position - sdfw_tr.position;
        DirasdqectionToLeader.z = 0;

        sdfw_tr.right = _trLeaderxcvse.right * 384f + (DirasdqectionToLeader.magnitude / CohesionasdqDistance * DirasdqectionToLeader) + DirecasdqtionRndqForce;

        if (IsRasdqotating)
        {
            AngqleActiasdveRotate += RoqtateSpdWitasdqhDirection * Time.deltaTime;
            DirecasdqtionRndqForce = Quaternion.Euler(0, 0, AngqleActiasdveRotate) * RndwForceqweRotate;
            ElapseRotaasdqte += Time.deltaTime;

            if (ElapseRotaasdqte > TimeqdRotateasd)
            {
                IsRasdqotating = false;
                ElapseRotaasdqte = 0;
            }
        }
        else
        {
            elapweElapseIntervalRotate += Time.deltaTime;
            if (elapweElapseIntervalRotate > TimeInteqwervalRotate)
            {
                IsRasdqotating = true;
                TimeInteqwervalRotate = Random.Range(0.1f, 2.5f);
                RoqtateSpdWitasdqhDirection = (Random.Range(0, 2) == 0 ? -1f : 1f) * asdasdq;
                elapweElapseIntervalRotate = 0;
            }
        }
    }
    void OnBecameInvisible()
    {
        if (_fsdfwol != null)
            _fsdfwol.deqwtroyOasdnList(transform);
    }

    public void SetLeaderasdq(Transform _leasdqader)
    {
        _trLeaderxcvse = _leasdqader;
        _swimLeaderasdq = _leasdqader.GetComponent<Swim>();
        _fsdfwol = _leasdqader.GetComponent<FishFlockLeaderControl>();
        CohesionasdqDistance = DistanceToLeaderasdq + _swimLeaderasdq.BoundqweqweCircleRadwius + _sdfwswim.BoundqweqweCircleRadwius;

    }
}
