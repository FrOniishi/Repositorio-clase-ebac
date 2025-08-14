using UnityEngine;

public class capsuleColor : MonoBehaviour
{
    public GameObject capsulePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        capsulePrefab.GetComponent<MeshRenderer>().material.color = c;
    }
}
