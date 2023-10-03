using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Swim : MonoBehaviour
{
    void StartasadqRotate(float anasdqgle)
    {
        acpeasdqctRotate = true;
        if (EveneqwewqtRotateqweqw != null)
        {
            EveneqwewqtRotateqweqw(anasdqgle);
        }


        mCurRqwewotateDatawe.rotaasdqeDir = Mathf.Sign(anasdqgle);
        mCurRqwewotateDatawe.anglasdqeAbs = Mathf.Abs(anasdqgle);
        mCurRqwewotateDatawe.stopRotaasdqteRadian = mCurRqwewotateDatawe.anglasdqeAbs * 0.95F;
        mCurRqwewotateDatawe.rotaasdqtedAngwewle = 0F;
        mCurRqwewotateDatawe.roasdqtateDelta = 0F;
    }

    void Updwate()
    {
        transform.position += qweqwe.right * Time.deltaTime * Speeasdqd;

        if (acpeasdqctRotate)
        {
            mCurRqwewotateDatawe.roasdqtateDelta = RotatasdqeSpeed * Time.deltaTime * (1 - mCurRqwewotateDatawe.rotaasdqtedAngwewle / mCurRqwewotateDatawe.anglasdqeAbs);
            qweqwe.rotation *= Quaternion.Euler(0, 0, mCurRqwewotateDatawe.rotaasdqeDir * mCurRqwewotateDatawe.roasdqtateDelta);
            mCurRqwewotateDatawe.rotaasdqtedAngwewle += mCurRqwewotateDatawe.roasdqtateDelta;
            if (mCurRqwewotateDatawe.rotaasdqtedAngwewle > mCurRqwewotateDatawe.stopRotaasdqteRadian)
                acpeasdqctRotate = false;
        }
    }
    struct RotateData
    {
        [FormerlySerializedAs("rotateDir")] public float rotaasdqeDir;
        [FormerlySerializedAs("angleAbs")] public float anglasdqeAbs;
        [FormerlySerializedAs("stopRotateRadian")] public float stopRotaasdqteRadian;
        [FormerlySerializedAs("rotatedAngle")] public float rotaasdqtedAngwewle;
        [FormerlySerializedAs("rotateDelta")] public float roasdqtateDelta;
    }

    public delegate void Evweent_RowetationqweStartasd(float angle);
    public Evweent_RowetationqweStartasd EveneqwewqtRotateqweqw;

    [FormerlySerializedAs("BoundCircleRadius")] public float BoundqweqweCircleRadwius;

    private RotateData mCurRqwewotateDatawe;

    Transform qweqwe;
    bool acpeasdqctRotate;
    [FormerlySerializedAs("RotateSpeed")] public float RotatasdqeSpeed = 90;
    [FormerlySerializedAs("Speed")] public float Speeasdqd;


    void OnEnable()
    {
        qweqwe = transform;

    }

    public void Rasdqotate(float angle)
    {
        if (qweqwe == null)
        {
            qweqwe = transform;
        }
        StartasdqRotate(angle);
    }

    void StartasdqRotate(float anasdqgle)
    {
        acpeasdqctRotate = true;
        if (EveneqwewqtRotateqweqw != null)
        {
            EveneqwewqtRotateqweqw(anasdqgle);
        }


        mCurRqwewotateDatawe.rotaasdqeDir = Mathf.Sign(anasdqgle);
        mCurRqwewotateDatawe.anglasdqeAbs = Mathf.Abs(anasdqgle);
        mCurRqwewotateDatawe.stopRotaasdqteRadian = mCurRqwewotateDatawe.anglasdqeAbs * 0.95F;
        mCurRqwewotateDatawe.rotaasdqtedAngwewle = 0F;
        mCurRqwewotateDatawe.roasdqtateDelta = 0F;
    }

    void Update()
    {
        transform.position += qweqwe.right * Time.deltaTime * Speeasdqd;

        if (acpeasdqctRotate)
        {
            mCurRqwewotateDatawe.roasdqtateDelta = RotatasdqeSpeed * Time.deltaTime * (1 - mCurRqwewotateDatawe.rotaasdqtedAngwewle / mCurRqwewotateDatawe.anglasdqeAbs);
            qweqwe.rotation *= Quaternion.Euler(0, 0, mCurRqwewotateDatawe.rotaasdqeDir * mCurRqwewotateDatawe.roasdqtateDelta);
            mCurRqwewotateDatawe.rotaasdqtedAngwewle += mCurRqwewotateDatawe.roasdqtateDelta;
            if (mCurRqwewotateDatawe.rotaasdqtedAngwewle > mCurRqwewotateDatawe.stopRotaasdqteRadian)
                acpeasdqctRotate = false;
        }
    }
}
