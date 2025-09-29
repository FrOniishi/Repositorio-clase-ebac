using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class colecciones : MonoBehaviour
{
    List<int> miFuncion = new List<int>();

    List<string> miFuncion2 = new List<string> { "Hola", "que", "tal", "todo", "Hola", "tal", "Hola" };

    Stack<string> miFuncion5 = new Stack<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            miFuncion.Add(Random.Range(1,20));
        }
        miFuncion.Sort();
        miFuncion.Reverse();
        foreach (int numero in miFuncion)
        {
            Debug.Log(numero);
        }

        HashSet<string> miFuncion3 = new HashSet<string>(miFuncion2);

        foreach (string palabra in miFuncion3)
        {
            Debug.Log(palabra);
        }

        miFuncion5.Push("Primero");
        miFuncion5.Push("Segundo");
        miFuncion5.Push("Tercero");
        miFuncion5.Push("Cuarto");
        miFuncion5.Push("Quinto");

        miFuncion5.Pop();

        foreach (string palabra in miFuncion5)
        {
            Debug.Log(palabra);
        }

        Queue<string> miFuncion4 = new Queue<string>(miFuncion5);

        Debug.Log("El primer elemento es: " + miFuncion4.Peek());
        miFuncion4.Dequeue();

        foreach (string palabra in miFuncion4)
        {
            Debug.Log(palabra);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
