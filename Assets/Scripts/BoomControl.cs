using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BoomControl : MonoBehaviour
{
    void Upsdate()
    {
        _posMasdqouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(_posMasdqouse.x, _posMasdqouse.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.Instsdfwance.boomsdfw();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitDameasdq(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(efasdqf, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }
    [FormerlySerializedAs("eff")] public GameObject efasdqf;
    Vector3 _posMasdqouse;
    void Update()
    {
        _posMasdqouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(_posMasdqouse.x, _posMasdqouse.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.Instsdfwance.boomsdfw();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitDameasdq(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(efasdqf, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }
}
