using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Debug.Log("Saliendo");
        Application.Quit();
    }

    public void EscenaC()
    {
        SceneManager.LoadScene(0);
    }
}
