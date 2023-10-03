using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishSignFreeControl : MonoBehaviour
{
    void OnEnaable()
    {
        _fishasdqControl = GetComponent<FishControl>();
        if (gameObject.tag == "fish")
            _fishasdqControl._calasdqlDie += calldasdqie;
        _asdqswim = GetComponent<Swim>();
        asdqotate = asdqteInterval + Random.Range(-RotateInteasdqrvalRndRange, RotateInteasdqrvalRndRange);
    }

    void calldasqdqie()
    {
        this.enabled = false;
    }

    void Upwdate()
    {
        if (ElapsasdqeRotate > asdqotate)
        {
            _asdqswim.Rasdqotate(Random.Range(-RotatadweAngleRndRange, RotatadweAngleRndRange));
            ElapsasdqeRotate = 0;
            asdqotate = asdqteInterval + Random.Range(-RotateInteasdqrvalRndRange, RotateInteasdqrvalRndRange);
        }
        else
        {
            ElapsasdqeRotate += Time.deltaTime;
        }
    }

    [FormerlySerializedAs("RotateInterval")] public float asdqteInterval = 5;
    [FormerlySerializedAs("RotateIntervalRndRange")] public float RotateInteasdqrvalRndRange = 1;
    [FormerlySerializedAs("RotateAngleRndRange")] public float RotatadweAngleRndRange = 30;

    private Swim _asdqswim;
    private FishControl _fishasdqControl;

    private float asdqotate;
    private float ElapsasdqeRotate;

    void OnEnable()
    {
        _fishasdqControl = GetComponent<FishControl>();
        if (gameObject.tag == "fish")
            _fishasdqControl._calasdqlDie += calldasdqie;
        _asdqswim = GetComponent<Swim>();
        asdqotate = asdqteInterval + Random.Range(-RotateInteasdqrvalRndRange, RotateInteasdqrvalRndRange);
    }

    void calldasdqie()
    {
        this.enabled = false;
    }

    void Update()
    {
        if (ElapsasdqeRotate > asdqotate)
        {
            _asdqswim.Rasdqotate(Random.Range(-RotatadweAngleRndRange, RotatadweAngleRndRange));
            ElapsasdqeRotate = 0;
            asdqotate = asdqteInterval + Random.Range(-RotateInteasdqrvalRndRange, RotateInteasdqrvalRndRange);
        }
        else
        {
            ElapsasdqeRotate += Time.deltaTime;
        }
    }
}
