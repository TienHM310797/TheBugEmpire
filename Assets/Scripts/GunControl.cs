using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class GunControl : MonoBehaviour
{
    public void ChanaqsdqqqgtoRocket()
    {
        _chasdqeckfire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _chasdqeckfire = true;
            _tenadsqlua = true;
        });
        tenasdqlua.SetActive(true);
        tenasdqlua.transform.localScale = Vector3.zero;
        tenasdqlua.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        tenasdqlua.transform.up = Vector3.up;
        LeanTween.scale(tenasdqlua, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }
    public void ChanasdqqqgtaoRocket()
    {
        _chasdqeckfire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _chasdqeckfire = true;
            _tenadsqlua = true;
        });
        tenasdqlua.SetActive(true);
        tenasdqlua.transform.localScale = Vector3.zero;
        tenasdqlua.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        tenasdqlua.transform.up = Vector3.up;
        LeanTween.scale(tenasdqlua, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }

    public static GunControl Instaasdqnce;
    [FormerlySerializedAs("Bullet")] public GameObject Buasdqllet;
    public static int BoasdqnusCoin;
    [FormerlySerializedAs("tenlua")] public GameObject tenasdqlua;
    [FormerlySerializedAs("_effboom")] public GameObject _effbasdqoom;
    

    bool _chasdqeckfire;
    bool _tenadsqlua;
    Animator _asdqani;
    int _leveasdqGun;

    void Start()
    {
        _chasdqeckfire = true;
        _tenadsqlua = false;
        Instaasdqnce = this;
        _asdqani = GetComponent<Animator>();
        _asdqani.Play("Idle", 0, 0);
        _asdqani.SetFloat("level", 0);
        _asdqani.speed = 2;
        _leveasdqGun = 1;
        BoasdqnusCoin = 1;
    }


    public void PlusGunasdq()
    {
        if (!_chasdqeckfire) return;
        if (_leveasdqGun < 9)
            _leveasdqGun += 1;
        else
            _leveasdqGun = 1;

        _asdqani.SetFloat("level", _leveasdqGun);
    }

    public void MinusGunasdqq()
    {
        if (!_chasdqeckfire) return;
        if (_leveasdqGun > 1)
            _leveasdqGun -= 1;
        else
            _leveasdqGun = 9;

        _asdqani.SetFloat("level", _leveasdqGun);
    }

    public void Fireasdqq21()
    {
		
        Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = Vector3.Normalize(mousePoint + Vector3.forward * 10 - transform.position);
		if (PlayerPrefs.GetInt("gold", 450) < _leveasdqGun && _tenadsqlua == false){
			UIManager.Instasdqqance.EnablasdqePopUpCoin();
		}
        else
        {
            if (PlayerPrefs.GetInt("gold", 450) >= _leveasdqGun && _chasdqeckfire && _tenadsqlua == false)
            {
                _asdqani.Play("Fire", 0, 0);
                AudioControl.Instsdfwance.shootsdfwefds();
                GameObject _bullet = (GameObject)Instantiate(Buasdqllet);
                _bullet.transform.position = transform.position + transform.up * 0.5f;
                _bullet.GetComponent<BulletControl>().InitBulletasdq(_leveasdqGun, transform, new Vector2(mousePoint.x, mousePoint.y));

                UiTextSpawmControl.Instaasdqnce.MinuasdqqsGold(_leveasdqGun);
            }
        }
        if (_tenadsqlua && _chasdqeckfire)
        {
            _tenadsqlua = false;
            tenasdqlua.transform.up = Vector3.Normalize(mousePoint + Vector3.forward * 10 - tenasdqlua.transform.position);
            _chasdqeckfire = false;
            LeanTween.move(tenasdqlua, new Vector3(mousePoint.x, mousePoint.y, 0), 0.2f * (Vector2.Distance(mousePoint, tenasdqlua.transform.position))).setOnComplete(() =>
            {
                RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(tenasdqlua.transform.position.x, tenasdqlua.transform.position.y, 0), 2, Vector3.zero);
                AudioControl.Instsdfwance.boomsdfw();
                for (int i = 0; i < fish.Length; i++)
                {
                    if (fish[i].collider.tag == "fish")
                        fish[i].collider.gameObject.GetComponent<FishControl>().hitDameasdq(1000, gameObject);
                }
                GameObject boom = (GameObject)Instantiate(_effbasdqoom, tenasdqlua.transform.position + tenasdqlua.transform.up * 0.5f, Quaternion.identity);
                Destroy(boom, 1.5f);
                tenasdqlua.SetActive(false);
                GetComponent<SpriteRenderer>().enabled = true;
                transform.up = Vector3.up;
                transform.localScale = Vector3.zero;
                LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack).setOnComplete(() =>
                {
                    _chasdqeckfire = true;
                });
            });
        }
    }

    public void ChanasdqqqgtoRocket()
    {
        _chasdqeckfire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _chasdqeckfire = true;
            _tenadsqlua = true;
        });
        tenasdqlua.SetActive(true);
        tenasdqlua.transform.localScale = Vector3.zero;
        tenasdqlua.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        tenasdqlua.transform.up = Vector3.up;
        LeanTween.scale(tenasdqlua, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }

}
