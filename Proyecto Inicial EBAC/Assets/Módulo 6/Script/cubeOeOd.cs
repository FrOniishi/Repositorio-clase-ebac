using UnityEngine;

public class cubeOeOd : MonoBehaviour
{
    public GameObject PrefabCube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        Color c = new Color(Random.value, Random.value, Random.value);
        MeshRenderer renderer = tempGameObject.GetComponent<MeshRenderer>();
        renderer.material = new Material(renderer.material);
        renderer.material.color = c;
        tempGameObject.transform.position = new Vector3(2, 8, 14);
    }
    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        Color c = new Color(Random.value, Random.value, Random.value);
        MeshRenderer renderer = tempGameObject.GetComponent<MeshRenderer>();
        renderer.material = new Material(renderer.material);
        renderer.material.color = c;
        tempGameObject.transform.position = new Vector3(2, 12, 14);
    }
}
