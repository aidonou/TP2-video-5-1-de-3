using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validar_contraseña : MonoBehaviour
{
    string contracorrecta;
    string contraUsuario;
    public Text ingresoUsuario;
    public Text textoMensaje;
    public GameObject cartelMensaje;

    void Start()
    {
        contracorrecta = "123";
        cartelMensaje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContraseña()
    {
        contraUsuario = ingresoUsuario.text;
        if (contraUsuario == contracorrecta)
        {
            cartelMensaje.SetActive(true);
            textoMensaje.text = "bienvenido";
        }
        else
        {
            cartelMensaje.SetActive(true);
            textoMensaje.text = "Contraseña incorrecta";
        }
    }
}
