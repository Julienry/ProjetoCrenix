using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorInicial : MonoBehaviour
{
    // Uma variável Vector4 capaz de armazenar os valores de uma cor
    [HideInInspector] public Vector4 cor;

    private void Start()
    {
        // Armazena a cor inicial da engrenagem em uma variável
        cor = gameObject.GetComponent<Image>().color;
    }
}
