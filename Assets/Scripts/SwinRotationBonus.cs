using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class SwinRotationBonus : MonoBehaviour
{
    void OnBecasmeVisible()
    {
        _chsdfeck = true;
    }

    void Updaete()
    {
        if (_chsdfeck == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, asdfw), 180 * Time.deltaTime / 5);
    }  void OnBeecameVisible()
    {
        _chsdfeck = true;
    }

    void Upwdate()
    {
        if (_chsdfeck == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, asdfw), 180 * Time.deltaTime / 5);
    }
    bool _chsdfeck;
    [FormerlySerializedAs("a")] public float asdfw;

    void OnBecameVisible()
    {
        _chsdfeck = true;
    }

    void Update()
    {
        if (_chsdfeck == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, asdfw), 180 * Time.deltaTime / 5);
    }
}
