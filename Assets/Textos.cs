using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    public Text dinheiro;
    public Text dps;
    public Text dpc;

    // Update is called once per frame
    void Update()
    {
        dinheiro.text = "Dinheiro: " + FormatarDecimal(Stats.dinheiro);
        dps.text = "DPS: " + FormatarDecimal(Stats.dps);
        dpc.text = "DPC: " + FormatarDecimal(Stats.dpc);
    }

    string FormatarDecimal(float valor)
    {
        return valor.ToString("0.0");
    }
}
