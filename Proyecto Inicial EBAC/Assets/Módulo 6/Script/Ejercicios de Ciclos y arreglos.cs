using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int[] arr3 = new int[5];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Random.Range(1, 11);
            arr2[i] = Random.Range(8, 20);

            arr3[i] = arr1[i] + arr2[i];

            Debug.Log(arr3[i]);
        }

        string[] arr4 = new string[5];
        arr4[0] = ("Esto");
        arr4[1] = ("es");
        arr4[2] = ("un");
        arr4[3] = ("arreglo");
        arr4[4] = ("String");

        string resultado = "";

        foreach (string i in arr4) 
        {
            resultado += i + " ";
        }

        Debug.Log(resultado);

        int[,] miMatriz = new int[2, 3] { { 1, 2, 3}, {4, 5, 6} };
        int[] miVector = new int[2] { 1, 2};

        int[] resultado1 = new int[3];

        for (int j = 0; j < 3; j++)
        {
            resultado1[j] = miMatriz[0, j] * miVector[0] + miMatriz[1, j] * miVector[1];
        }

        Debug.Log(string.Join(", ", resultado1));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
