using UnityEngine;

public class capsuleColor1 : MonoBehaviour
{
    public GameObject capsulePrefab1;

    public GameObject firstGO;
    public GameObject secondGO;

    private cubeColor scriptA;
    private sphereColor scriptB;

    private Renderer myRenderer;
    public bool finalState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scriptA = firstGO.GetComponent<cubeColor>();
        scriptB = secondGO.GetComponent<sphereColor>();
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        /*Color c = new Color(Random.value, Random.value, Random.value);
        capsulePrefab.GetComponent<MeshRenderer>().material.color = c;*/

        bool stateA = scriptA.changeColor;
        bool stateB = scriptB.changeColor;

        finalState = stateA || stateB;

        if (finalState)
        {
            myRenderer.material.color = Color.white;
        }
        else
        {
            myRenderer.material.color = Color.black;
        }
    }
}
