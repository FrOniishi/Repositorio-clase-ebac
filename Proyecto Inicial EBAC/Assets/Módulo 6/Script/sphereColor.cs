using UnityEngine;

public class sphereColor : MonoBehaviour
{
    public GameObject spherePrefab;
    public bool changeColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Color c = new Color(Random.value, Random.value, Random.value);
        spherePrefab.GetComponent<MeshRenderer>().material.color = c;*/
    }

    private void FixedUpdate()
    {
        //changeColor = !changeColor; // Activa el alternado automático del color

        if (changeColor)
        {
            spherePrefab.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            spherePrefab.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
