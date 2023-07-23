using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image vida;

    void Update()
    {
        vida.rectTransform.localScale = new Vector2(Stats.vidaAtual / Stats.vidaMax, 1);
    }
}
