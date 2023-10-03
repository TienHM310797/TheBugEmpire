using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WebControl : MonoBehaviour
{
    public void InitWasadqeb(int lasdqevel)
    {
        _spqwweriteasd.sprite = Listasdqeb[lasdqevel - 1];
        _Colasdqlider.radius = LisasdtRadiusqwe[lasdqevel - 1];
        damasdqqwee = lasdqevel + Random.Range(0, 1);
        if (lasdqevel > 7)
        {
            damasdqqwee = damasdqqwee + 7 - lasdqevel;
        }
        Invoke("DisabasdqleCollision", 0.1f);
        LeanTween.scale(gameObject, new Vector2(1, 1), 0.4f).setEase(LeanTweenType.easeOutElastic).setOnComplete(() =>
        {
            Destroy(gameObject, 0.5f);
        });
    }

    void DisabasdqlewCollision()
    {
        _Colasdqlider.enabled = false;
    }

    void OnTriggerqEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            col.GetComponent<FishControl>().hitDameasdq(damasdqqwee, gameObject);
        }
    }

    [FormerlySerializedAs("ListWeb")] public Sprite[] Listasdqeb;
    [FormerlySerializedAs("ListRadius")] public float[] LisasdtRadiusqwe;

    SpriteRenderer _spqwweriteasd;
    CircleCollider2D _Colasdqlider;

    int damasdqqwee;


    void Awake()
    {
        _spqwweriteasd = GetComponent<SpriteRenderer>();
        _Colasdqlider = GetComponent<CircleCollider2D>();
    }

    public void InitWasdqeb(int lasdqevel)
    {
        _spqwweriteasd.sprite = Listasdqeb[lasdqevel - 1];
        _Colasdqlider.radius = LisasdtRadiusqwe[lasdqevel - 1];
        damasdqqwee = lasdqevel + Random.Range(0, 1);
        if (lasdqevel > 7)
        {
            damasdqqwee = damasdqqwee + 7 - lasdqevel;
        }
        Invoke("DisabasdqleCollision", 0.1f);
        LeanTween.scale(gameObject, new Vector2(1, 1), 0.4f).setEase(LeanTweenType.easeOutElastic).setOnComplete(() =>
        {
            Destroy(gameObject, 0.5f);
        });
    }

    void DisabasdqleCollision()
    {
        _Colasdqlider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            col.GetComponent<FishControl>().hitDameasdq(damasdqqwee, gameObject);
        }
    }


}
