using UnityEngine;
using System.Collections;

public class deactiveThuong : MonoBehaviour {
    void OnsEnable()
    {
        Invoke("deactive", 0.8f);
    }

    void deactiqve()
    {
        gameObject.SetActive(false);
    }
    void OnEnable()
    {
        Invoke("deactive", 0.8f);
    }

    void deactive()
    {
        gameObject.SetActive(false);
    }
}
