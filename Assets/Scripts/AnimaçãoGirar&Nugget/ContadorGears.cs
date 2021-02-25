using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorGears : MonoBehaviour
{
    // Variável responsável por contar quantas engrenagens estão encaixadas nos slots
    [HideInInspector] public static int contaGear = 0;
    
    // Boolean responsável por responder (true) se todas as engrenagens estiverem encaixadas, e (false) se
    // não estiverem todas encaixadas
    [HideInInspector] public static bool gearsAtivados;

    // Objeto TextoNugget feito para mudar o texto dito pelo Nugget dependendo da situação
    private TextoNugget textoNugget;
    
    void Start()
    {
        textoNugget = GetComponent<TextoNugget>();
    }

    void Update()
    {
        // Se todas as engrenagens estiverem encaixadas( 5 no total )... 
        if(contaGear == 5)
        {
            // O boolean é marcado como true, assim permitindo que as engrenagens girem
            gearsAtivados = true;

            // O texto do Nugget para as engrenagens encaixadas
            textoNugget.TextoEncaixado();
        }
        // Se nem todas as engrenagens estiverem encaixadas...
        else
        {
            // O boolean é marcado como true, não permitindo que as engrenagens girem
            gearsAtivados = false;
            // O texto do Nugget dizendo para encaixar as engrenagens
            textoNugget.TextoEncaixe();
        }
    }
}


