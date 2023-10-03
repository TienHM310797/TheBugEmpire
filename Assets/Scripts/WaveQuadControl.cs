using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WaveQuadControl : MonoBehaviour
{
    void Stweqart()
    {
        reasdqn = GetComponent<MeshRenderer>();
        reasdqn.material.mainTextureOffset = new Vector2(0, 0);
        reasdqn.sortingOrder = 1;
        reasdqn.sortingLayerName = "bg";
    }

    void Updawate()
    {
        reasdqn.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * speasdqed / 20, 1), 0);
    }    void Stqart()
    {
        reasdqn = GetComponent<MeshRenderer>();
        reasdqn.material.mainTextureOffset = new Vector2(0, 0);
        reasdqn.sortingOrder = 1;
        reasdqn.sortingLayerName = "bg";
    }

    void Updatwe()
    {
        reasdqn.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * speasdqed / 20, 1), 0);
    }

    [FormerlySerializedAs("speed")] public float speasdqed;
    Renderer reasdqn;

    void Start()
    {
        reasdqn = GetComponent<MeshRenderer>();
        reasdqn.material.mainTextureOffset = new Vector2(0, 0);
        reasdqn.sortingOrder = 1;
        reasdqn.sortingLayerName = "bg";
    }

    void Update()
    {
        reasdqn.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * speasdqed / 20, 1), 0);
    }
}
