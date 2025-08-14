using UnityEngine;

public class genCube : MonoBehaviour
{
    public GameObject PrefabCube;

    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCube);
        Color c = new Color(Random.value, Random.value, Random.value);
        MeshRenderer renderer = tempGameObject.GetComponent<MeshRenderer>();
        renderer.material = new Material(renderer.material);
        renderer.material.color = c;
        tempGameObject.transform.position = new Vector3(2, 4, 14);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
