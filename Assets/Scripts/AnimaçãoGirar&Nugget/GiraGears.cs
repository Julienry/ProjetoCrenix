using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraGears : MonoBehaviour
{
    public bool antiHorario; // Checa se a engenagem vai girar em horário ou anti-horário

    void FixedUpdate()
    {
        if (ContadorGears.gearsAtivados) // Checa se todas as engrenagens estão encaixadas através do script ContadorGears
        {
            // Se a opção antiHorario não estiver marcada, as engrenagens giram em sentido horário
            if (!antiHorario)
            {
                transform.Rotate(0, 0, -1);
            }
            // Se a opção antiHorario estiver marcada, as engrenagens giram em sentido anti-horário
            else
            {
                transform.Rotate(0, 0, 1);
            }
        }
    }
}
