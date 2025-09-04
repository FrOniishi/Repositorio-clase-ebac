using UnityEngine;

public class capsuleColor2 : MonoBehaviour
{
    public GameObject capsulePrefab2;

    public GameObject thirdGO;
    public GameObject fourthGO;

    private capsuleColor scriptA;
    private capsuleColor1 scriptB;

    private Renderer myRenderer;
    private bool finalState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scriptA = thirdGO.GetComponent<capsuleColor>();
        scriptB = fourthGO.GetComponent<capsuleColor1>();
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

        bool stateA = scriptA.finalState;
        bool stateB = scriptB.finalState;

        finalState = stateA && stateB;

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
