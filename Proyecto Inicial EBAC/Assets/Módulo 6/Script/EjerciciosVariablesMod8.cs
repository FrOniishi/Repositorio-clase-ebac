using System;
using UnityEngine;
using UnityEngine.Rendering;

public class EjerciciosVariableMod8 : MonoBehaviour
{
    private Renderer myRenderer;

    public GameObject cubo; // Asigna el cubo desde el Inspector

    int numeroEntero = 0;
    int a = 5;
    int b = 10;
    int aleatorio;

    float numeroDecimal = 1f;
    float numero1;
    float numero2;
    float numero3;

    string nombreCompleto = "Franco Romero Araujo";
    string mensaje = "Hola Mundo";
    string mensaje2 = "Estoy aprendiendo C# en Unity";

    public string colorSeleccionado = "rojo";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float numero1 = 5.75f;
        float numero2 = 2.40f;
        float numero3 = 3.505699f;

        string valor1 = "2500";
        string valor2 = "4300";
        string resultado = "";

        float resultadoFlotante = numero1 * numero2;

        int resultadoEntero = (int)resultadoFlotante;
        int numero4, numero5;
        int indice = 0;

        Debug.Log("Resultado flotante: " + resultadoFlotante);
        Debug.Log("Resultado entero: " + resultadoEntero);

        myRenderer = GetComponent<Renderer>();

        string texto = numero3.ToString("F4");
        Debug.Log("Número 3 con 4 decimales: " + texto);

        String nombre = nombreCompleto.Substring(0, 6);
        String apellido1 = nombreCompleto.Substring(7, 6);
        String apellido2 = nombreCompleto.Substring(14, 6);

        Debug.Log("Nombre: " + nombre);
        Debug.Log("Primer Apellido: " + apellido1);
        Debug.Log("Segundo Apellido: " + apellido2);

        string[] partes = nombreCompleto.Split(' ');
        Debug.Log("Nombre (usando Split): " + partes[0]);
        Debug.Log("Primer Apellido (usando Split): " + partes[1]); 
        Debug.Log("Segundo Apellido (usando Split): " + partes[2]);

        bool conversion1 = int.TryParse(valor1, out numero4);
        bool conversion2 = int.TryParse(valor2, out numero5);

        if (conversion1 && conversion2)
        {
            int suma = numero4 + numero5;
            Debug.Log("Resultado de la suma: " + suma);
        }
        else
        {
            Debug.LogWarning("Error al convertir uno o ambos valores.");
        }

        while (indice < mensaje.Length)
        {
            if(indice % 2 == 0)
            {
                resultado += mensaje[indice];
            }
            indice++;
        }

        Debug.Log("Caracteres en posiciones pares: " + resultado);

        string mensajeCortado = mensaje2.Substring(5, 24);
        Debug.Log("Mensaje cortado: " + mensajeCortado);
    }

    // Update is called once per frame
    void Update()
    {
        numeroEntero++;
        Debug.Log("Valor del número entero: " + numeroEntero);
        CambiarColor(colorSeleccionado);
    }

    /*private void FixedUpdate()
    {
        numeroDecimal *= 1.2f;
        Debug.Log("Valor del número decimal: " + numeroDecimal);

        aleatorio = UnityEngine.Random.Range(a, b);
        if (aleatorio % 2 == 0)
        {
            Debug.Log("El número " + aleatorio + " es par");
            myRenderer.material.color = Color.white;
        }
        else
        {
            Debug.Log("El número " + aleatorio + " es impar");
            myRenderer.material.color = Color.black;
        }
    }*/
    void CambiarColor(string color)
    {
        Renderer renderer = cubo.GetComponent<Renderer>();

        switch (color.ToLower())
        {
            case "rojo":
                renderer.material.color = Color.red;
                break;
            case "verde":
                renderer.material.color = Color.green;
                break;
            case "azul":
                renderer.material.color = Color.blue;
                break;
            case "amarillo":
                renderer.material.color = Color.yellow;
                break;
            default:
                Debug.LogWarning("Color no reconocido. Se asigna blanco por defecto.");
                renderer.material.color = Color.white;
                break;
        }
    }
    
}
