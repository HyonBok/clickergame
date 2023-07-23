using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timer = 0.1f;

    void Update()
    {
        // Timer
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            DanoSegundo();
            timer = 0.1f;
        }

        if(Stats.vidaAtual <= 0)
            MatarMonstro(true);
    }

    static public void DanoClick()
    {
        Stats.vidaAtual -= Stats.dpc;
    }

    void DanoSegundo()
    {
        Stats.vidaAtual -= Stats.dps / 10;
    }

    static public void MatarMonstro(bool receber)
    {
        Stats.vidaAtual = Stats.vidaMax;

        // Caso tenha matado, (e não mudado de fase)
        if (receber)
            Stats.dinheiro += Stats.valorMonstro;
    }
}
