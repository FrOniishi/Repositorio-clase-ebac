using UnityEngine;

public class sphereColor : MonoBehaviour
{
    public GameObject spherePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        spherePrefab.GetComponent<MeshRenderer>().material.color = c;
    }
}
