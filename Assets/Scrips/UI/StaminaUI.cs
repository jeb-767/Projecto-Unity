using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaUI : MonoBehaviour

{
    public TMPro.TextMeshProUGUI texto;

    void OnEnable()

    {
        ControladorJugador.CambioStamina += ActualizarUI; 
    }

    void OnDisable()
    {
        ControladorJugador.CambioStamina += ActualizarUI;
    }

    void ActualizarUI(float stamina)
    {
        texto.text = ((int)stamina).ToString();
    }
}
