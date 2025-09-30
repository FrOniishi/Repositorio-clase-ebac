using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class colecciones : MonoBehaviour
{
    int parametro1 = 5;
    int parametro2 = 10;
    int parametro3 = 20;

    List<string> palabrasAleatorias = new List<string> { "Hola", "que", "tal", "todo", "Hola", "tal", "Hola" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lista_ordenada();
        HashSet<string> sinRepetidos = EliminarRepetidos(palabrasAleatorias);

        foreach (string palabra in sinRepetidos)
        {
            Debug.Log(palabra);
        }

        string[] elementosPila = { "Elemento1", "Elemento2", "Elemento3", "Elemento4" };
        ProcesarEstructuras(elementosPila);
    }

    void lista_ordenada()
    {
        List<int> resultado = listaNumeros(parametro1, parametro2, parametro3);
        List<int> ordenada = OrdenarDescendente(resultado);

        foreach (int numero in ordenada)
        {
            Debug.Log(numero);
        }
    }

    public List<int> listaNumeros(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> listaAleatoria = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            listaAleatoria.Add(Random.Range(rangoInferior, rangoSuperior));
        }

        return listaAleatoria;
    }

    public List<int> OrdenarDescendente(List<int> entrada)
    {
        List<int> copia = new List<int>(entrada);

        copia.Sort();
        copia.Reverse();

        return copia;
    }

    public HashSet<string> EliminarRepetidos(List<string> entrada)
    {
        HashSet<string> resultado = new HashSet<string>();

        foreach (string elemento in entrada)
        {
            resultado.Add(elemento);
        }

        return resultado;
    }

    public void ProcesarEstructuras(string[] elementos)
    {
        Stack<string> pila = new Stack<string>();
        foreach (string elemento in elementos)
        {
            pila.Push(elemento);
        }

        Queue<string> cola = new Queue<string>();

        Stack<string> copiaPila = new Stack<string>(pila);
        foreach (string _ in copiaPila)
        {
            string cima = pila.Peek();
            Debug.Log("Peek de pila: " + cima);

            cola.Enqueue(cima);
            Debug.Log("Enqueue a cola: " + cima);

            pila.Pop();
            Debug.Log("Pop de pila: " + cima);
        }

        int cantidad = cola.Count;
        for (int i = 0; i < cantidad; i++)
        {
            string frente = cola.Peek();
            Debug.Log("Peek de cola: " + frente);

            cola.Dequeue();
            Debug.Log("Dequeue de cola: " + frente);
        }
    }

}

