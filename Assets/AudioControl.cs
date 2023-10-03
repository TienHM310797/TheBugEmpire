using UnityEngine;
using System.Collections;
using DarkTonic.MasterAudio;

public class AudioControl : MonoBehaviour
{

    public void nguyenssdfwtu()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("nguyentu");
        }
    }

    public void boomqsdfw()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("bom");
        }
    }

    public void sdfwscoin()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("coin");
        }
    }
    
    public static bool _isSoundsdfwwerfsdf = true;
    public static bool _isMusicsdfw = true;
    public static AudioControl Instsdfwance;
    public static int _indexMsdfwusic=1;

    void Awake()
    {
        Instsdfwance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void openbgsdfw()
    {
        if (_isMusicsdfw)
        {
            _indexMsdfwusic = Random.Range(1, 5);
            MasterAudio.PlaySound("bg" + _indexMsdfwusic);
        }
    }

    public void Offbgsdfw()
    {
        MasterAudio.StopAllOfSound("bg" + _indexMsdfwusic);
    }

    public void shootsdfwefds()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("shot");
        }
    }

    public void clicksdfwButton()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("button");
        }
    }

    public void nguyensdfwtu()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("nguyentu");
        }
    }

    public void boomsdfw()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("bom");
        }
    }

    public void sdfwcoin()
    {
        if (_isSoundsdfwwerfsdf)
        {
            MasterAudio.PlaySound("coin");
        }
    }
}
