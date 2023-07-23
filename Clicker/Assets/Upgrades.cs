using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public string texto;

    public float preco;
    public float multiplicador = 1;
    //public float aumento = 1;

    private void Update()
    {
        gameObject.GetComponentInChildren<Text>().text = texto + ": " + (int)preco;
    }

    private void Compra()
    {
        Stats.dinheiro -= preco;
        preco *= multiplicador;
    }

    public void AumentarDpc(float valor)
    {
        if (Stats.dinheiro < preco)
            return;

        Stats.dpc += valor;
        Compra();
    }

    public void AumentarDps(float valor)
    {
        if (Stats.dinheiro < preco)
            return;

        Stats.dps += valor;
        Compra();
    }
}
