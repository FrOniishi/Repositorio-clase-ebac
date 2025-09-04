using UnityEngine;

public class cubeColor : MonoBehaviour
{
    public GameObject cubePrefab;
    public bool changeColor;

    private void Awake()
    {
       /* Color c = new Color(Random.value, Random.value, Random.value);
        cubePrefab.GetComponent<MeshRenderer>().material.color = c;*/
    }
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
        //changeColor = !changeColor; // Activa el alternado automático del color

        if (changeColor)
        {
            cubePrefab.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            cubePrefab.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
