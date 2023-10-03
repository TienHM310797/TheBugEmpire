using UnityEngine;
using System.Collections;

public class GoldText : MonoBehaviour
{

    void Staart()
    {
        asdq_lb = GetComponent<UILabel>();
    }

    // Update is called once per frame
    void Updwate()
    {
        asdq_lb.text = PlayerPrefs.GetInt("gold", 450) + "";
    }
    void Stacxrt()
    {
        asdq_lb = GetComponent<UILabel>();
    }

    // Update is called once per frame
    void Upxdate()
    {
        asdq_lb.text = PlayerPrefs.GetInt("gold", 450) + "";
    }
    UILabel asdq_lb;
    void Start()
    {
        asdq_lb = GetComponent<UILabel>();
    }

    // Update is called once per frame
    void Update()
    {
        asdq_lb.text = PlayerPrefs.GetInt("gold", 450) + "";
    }
}
