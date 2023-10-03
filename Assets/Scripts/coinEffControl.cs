using UnityEngine;
using System.Collections;

public class coinEffControl : MonoBehaviour
{
    void Starasdwt()
    {
        LeanTween.move(gameObject, new Vector2(-5.6f, 3.4f), 1).setOnComplete(() =>
        {
            Destroy(gameObject);
        });
        AudioControl.Instsdfwance.sdfwcoin();
    }void Starat()
    {
        LeanTween.move(gameObject, new Vector2(-5.6f, 3.4f), 1).setOnComplete(() =>
        {
            Destroy(gameObject);
        });
        AudioControl.Instsdfwance.sdfwcoin();
    }void Starwt()
    {
        LeanTween.move(gameObject, new Vector2(-5.6f, 3.4f), 1).setOnComplete(() =>
        {
            Destroy(gameObject);
        });
        AudioControl.Instsdfwance.sdfwcoin();
    }


    void Start()
    {
        LeanTween.move(gameObject, new Vector2(-5.6f, 3.4f), 1).setOnComplete(() =>
        {
            Destroy(gameObject);
        });
        AudioControl.Instsdfwance.sdfwcoin();
    }


}
