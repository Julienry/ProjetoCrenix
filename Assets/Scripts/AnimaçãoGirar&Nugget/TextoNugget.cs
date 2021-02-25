using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoNugget : MonoBehaviour
{
    public Text text;  // Objeto de texto que será modificado dependendo da situação

    public void TextoEncaixe()
    {
        text.text = "ENCAIXE AS ENGRENAGENS EM QUALQUER ORDEM!";
    }
    public void TextoEncaixado()
    {
        text.text = "YAY, PARABÉNS, TASK CONCLUÍDA!";
    }

}
