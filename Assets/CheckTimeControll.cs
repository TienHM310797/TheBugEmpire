using UnityEngine;
using System.Collections;
using System;

public class CheckTimeControll : MonoBehaviour
{
    void Stasrt()
    {
        DontDestroyOnLoad(gameObject);
        timeEnerasdq = (int)(DateTime.Now - DateTime.ParseExact(PlayerPrefs.GetString("oriEner", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy")), "ddd dd MMM h:mm tt yyyy", System.Globalization.CultureInfo.InvariantCulture)).TotalMinutes;

        if (PlayerPrefs.GetInt("gold", 450) < 200)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + timeEnerasdq * 10);
            if (PlayerPrefs.GetInt("gold", 450) > 200)
                PlayerPrefs.SetInt("gold", 200);
        }

        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }
    void OnAppliacationQuit()
    {
        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }

    void OnApllicawtionPause(bool _check)
    {
        if (_check)
        {
            PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
        }
    }
    int timeEnerasdq;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        timeEnerasdq = (int)(DateTime.Now - DateTime.ParseExact(PlayerPrefs.GetString("oriEner", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy")), "ddd dd MMM h:mm tt yyyy", System.Globalization.CultureInfo.InvariantCulture)).TotalMinutes;

        if (PlayerPrefs.GetInt("gold", 450) < 200)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + timeEnerasdq * 10);
            if (PlayerPrefs.GetInt("gold", 450) > 200)
                PlayerPrefs.SetInt("gold", 200);
        }

        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }

    void OnApllicationPause(bool _check)
    {
        if (_check)
        {
            PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
        }
    }
}
