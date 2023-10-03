using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus4Control : MonoBehaviour
{
    void OnEnaasdble()
    {
        limitasdqHieght = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < _preasdqfab.Length; i++)
            {
                Transform _tr = Instantiate(_preasdqfab[i]);

                _tr.position = new Vector2(2f + i, -limitasdqHieght - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().asdqBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < _preasdqfab.Length; i++)
            {
                Transform _tr = Instantiate(_preasdqfab[i]);

                _tr.position = new Vector2(2f + i, limitasdqHieght + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().asdqBonus4(2f + i, a);
            }
        }
    }
    [FormerlySerializedAs("_prefab")] public Transform[] _preasdqfab;
    float limitasdqHieght;

    void OnEnable()
    {
        limitasdqHieght = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < _preasdqfab.Length; i++)
            {
                Transform _tr = Instantiate(_preasdqfab[i]);

                _tr.position = new Vector2(2f + i, -limitasdqHieght - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().asdqBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < _preasdqfab.Length; i++)
            {
                Transform _tr = Instantiate(_preasdqfab[i]);

                _tr.position = new Vector2(2f + i, limitasdqHieght + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().asdqBonus4(2f + i, a);
            }
        }
    }
}
