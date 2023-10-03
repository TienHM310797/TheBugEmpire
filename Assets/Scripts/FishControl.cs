using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishControl : MonoBehaviour
{
    Swim _swaiasdqm;
    int asdq_whp;
    GameObject _checkCoassddqwallsion;

    bool _checkIasdqasdnvisible;


 void OnBecameVi32sible()
    {
        if (gameObject.tag == "fish")
        {
            if (_checkIasdqnvisible) return;
            _checkIasdqnvisible = true;
            FishManage.Inasdqstance._FishMangeasdq.Add(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Inasdqstance._CaasdMapManagew.Add(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Inasdqstance._MwucMaasdqnager.Add(transform);
                }
            }
        }
    }

    void OnDestqroy()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Inasdqstance._FishMangeasdq.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Inasdqstance._CaasdMapManagew.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Inasdqstance._MwucMaasdqnager.Remove(transform);
                }
            }
        }
    }

    void OnBecamseInvisible()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Inasdqstance._FishMangeasdq.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Inasdqstance._CaasdMapManagew.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Inasdqstance._MwucMaasdqnager.Remove(transform);
                }
            }
        }
        Destroy(gameObject);

    }
    
    [FormerlySerializedAs("AnimationName")] public string AnimasdqationName;
    [FormerlySerializedAs("AnimationNameDie")] public string AnimatioqdasnNameDieasd;
    Animator _aniasdq;

    [FormerlySerializedAs("Hp")] public int asdq;
    [FormerlySerializedAs("RndHp")] public int RnxcvwdHp;

    [FormerlySerializedAs("HpMax")] public int HpMxcvwax;
    [FormerlySerializedAs("RndHpMax")] public int RndssHpMaxzxcfwed;

    Swim _swiasdqm;
    int asdq_hp;
    GameObject _checkCoasdqwallsion;

    bool _checkIasdqnvisible;

    public delegate void CallDiasdqe();
    public CallDiasdqe _calasdqlDie;

    [FormerlySerializedAs("_gold")] public int _golasdqd;

    void OnEnable()
    {
        _checkIasdqnvisible = false;
        _aniasdq = GetComponent<Animator>();
        _aniasdq.Play(AnimasdqationName, 0, Random.Range(0f, 1f));

        _swiasdqm = GetComponent<Swim>();

        if (Random.Range(0, 2) == 1)
            asdq_hp = Random.Range(HpMxcvwax - RndssHpMaxzxcfwed, HpMxcvwax + RndssHpMaxzxcfwed);
        else
            asdq_hp = Random.Range(asdq - RnxcvwdHp, asdq - RnxcvwdHp);
    }

    public void hitDameasdq(int damasdqe, GameObject oasdqbj)
    {
        if (_checkCoasdqwallsion == null || (_checkCoasdqwallsion.GetInstanceID() != oasdqbj.GetInstanceID()))
        {
            asdq_hp -= damasdqe;
            _checkCoasdqwallsion = oasdqbj;

            if (asdq_hp <= 0)
            {
                if (_calasdqlDie != null)
                {
                    _calasdqlDie();
                }
                _swiasdqm.enabled = false;
                _aniasdq.Play(AnimatioqdasnNameDieasd, 0, 0);
                GetComponent<BoxCollider2D>().enabled = false;
                Instantiate(Resources.Load("coinEff"), transform.position + Vector3.up * 0.5f, Quaternion.identity);
                UiTextSpawmControl.Instaasdqnce.CallTeasdqxtEff(transform.position + Vector3.up * 0.5f, _golasdqd);
                FishManage.Inasdqstance._FishMangeasdq.Remove(transform);
                Destroy(gameObject, 0.8f);
            }
        }
    }

    public void CollisionasdqWithWave()
    {
        if (_calasdqlDie != null)
        {
            _calasdqlDie();
        }
        FishManage.Inasdqstance._FishMangeasdq.Remove(transform);
        Destroy(gameObject);


    }


    void OnBecameVisible()
    {
        if (gameObject.tag == "fish")
        {
            if (_checkIasdqnvisible) return;
            _checkIasdqnvisible = true;
            FishManage.Inasdqstance._FishMangeasdq.Add(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Inasdqstance._CaasdMapManagew.Add(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Inasdqstance._MwucMaasdqnager.Add(transform);
                }
            }
        }
    }

    void OnDestroy()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Inasdqstance._FishMangeasdq.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Inasdqstance._CaasdMapManagew.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Inasdqstance._MwucMaasdqnager.Remove(transform);
                }
            }
        }
    }

    void OnBecameInvisible()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Inasdqstance._FishMangeasdq.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Inasdqstance._CaasdMapManagew.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Inasdqstance._MwucMaasdqnager.Remove(transform);
                }
            }
        }
        Destroy(gameObject);

    }
}
