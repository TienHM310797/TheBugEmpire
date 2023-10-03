using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class changbonus : MonoBehaviour
{
    void OnEnasable()
    {
        //  chil[Random.Range(0, chil.Length)].SetActive(true);
        chilasdq[0].SetActive(true);
    }
    
    void OnEnasble()
    {
        //  chil[Random.Range(0, chil.Length)].SetActive(true);
        chilasdq[0].SetActive(true);
    }

    [FormerlySerializedAs("chil")] public GameObject[] chilasdq;

    void OnEnable()
    {
      //  chil[Random.Range(0, chil.Length)].SetActive(true);
        chilasdq[0].SetActive(true);
    }
}
