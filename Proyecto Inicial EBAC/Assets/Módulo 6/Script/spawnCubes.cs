using UnityEngine;

public class spawnCubes : MonoBehaviour
{
    public GameObject PrefabCube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        Color c = new Color(Random.value, Random.value, Random.value);
        MeshRenderer renderer = tempGameObject.GetComponent<MeshRenderer>();
        renderer.material = new Material(renderer.material);
        renderer.material.color = c;
        PrefabCube.transform.position = Random.insideUnitSphere * 10;
    }
}
