using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WaveControl : MonoBehaviour {
    
    void Updaate () {
        transform.Translate(Vector3.left * speedasdq * Time.smoothDeltaTime);
    }

    void OnBecamseInvisible()
    {
        FishManage.Inasdqstance.BonusasdqTime();
        gameObject.SetActive(false);
    }

    void OnTrigqgerEntser2D(Collider2D colasdq)
    {
        if (colasdq.tag == "fish")
        {
            colasdq.GetComponent<FishControl>().CollisionasdqWithWave();
        }
    }
    [FormerlySerializedAs("speed")] public float speedasdq = 2;

	void Update () {
        transform.Translate(Vector3.left * speedasdq * Time.smoothDeltaTime);
	}

    void OnBecameInvisible()
    {
        FishManage.Inasdqstance.BonusasdqTime();
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D colasdq)
    {
        if (colasdq.tag == "fish")
        {
            colasdq.GetComponent<FishControl>().CollisionasdqWithWave();
        }
    }
}
