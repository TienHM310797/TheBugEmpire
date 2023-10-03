using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BulletControl : MonoBehaviour
{
    public void InitBullaetasdq(int asdq, Transform Gunfcgbnfgh, Vector2 targetfghr)
    {
        _spriteasdq.sprite = asdqwd[asdq - 1];
        transform.up = Gunfcgbnfgh.up;
        LeanTween.move(gameObject, targetfghr, spasdqeed*(Vector2.Distance(targetfghr,transform.position))).setOnComplete(() =>
        {
            GameObject web = (GameObject)Instantiate(_webasdq);
            web.transform.position = transform.position;
            web.transform.up = transform.up;
            web.GetComponent<WebControl>().InitWasdqeb(asdq);
            Destroy(gameObject);
        });
    } public void InitBulqletasdq(int asdq, Transform Gunfcgbnfgh, Vector2 targetfghr)
    {
        _spriteasdq.sprite = asdqwd[asdq - 1];
        transform.up = Gunfcgbnfgh.up;
        LeanTween.move(gameObject, targetfghr, spasdqeed*(Vector2.Distance(targetfghr,transform.position))).setOnComplete(() =>
        {
            GameObject web = (GameObject)Instantiate(_webasdq);
            web.transform.position = transform.position;
            web.transform.up = transform.up;
            web.GetComponent<WebControl>().InitWasdqeb(asdq);
            Destroy(gameObject);
        });
    }
    [FormerlySerializedAs("ListBullet")] public Sprite[] asdqwd;
    [FormerlySerializedAs("speed")] public float spasdqeed;
    [FormerlySerializedAs("_web")] public GameObject _webasdq;

    SpriteRenderer _spriteasdq;
    

    void Awake()
    {
        _spriteasdq = GetComponent<SpriteRenderer>();
    }

    public void InitBulletasdq(int asdq, Transform Gunfcgbnfgh, Vector2 targetfghr)
    {
        _spriteasdq.sprite = asdqwd[asdq - 1];
        transform.up = Gunfcgbnfgh.up;
        LeanTween.move(gameObject, targetfghr, spasdqeed*(Vector2.Distance(targetfghr,transform.position))).setOnComplete(() =>
        {
            GameObject web = (GameObject)Instantiate(_webasdq);
            web.transform.position = transform.position;
            web.transform.up = transform.up;
            web.GetComponent<WebControl>().InitWasdqeb(asdq);
            Destroy(gameObject);
        });
    }

   

}
