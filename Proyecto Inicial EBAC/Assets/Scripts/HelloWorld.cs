using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World From Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World From Update");

    }

    private void Awake()
    {
        Debug.Log("Hello World From Awake");
    }

    private void FixedUpdate()
    {
        Debug.Log("Hello World From Update Fixed");

    }

    private void LateUpdate()
    {
        Debug.Log("Hello World From LateUpdate");

    }
}
