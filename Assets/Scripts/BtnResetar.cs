using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnResetar : MonoBehaviour
{
    private GameObject[] gears; // Declara um vetor para inserir as engrenagens do cenário

    private GameObject[] gearsUI; // Declara um vetor para inserir as engrenagens do inventário
    
    private CorInicial corInicial; // Declara um objeto CorInicial para ser possível resetar as cores das engrenagens

    
    // Se o botão Reset é apertado, esse método é ativado
    public void Resetar()
    {
        ContadorGears.contaGear = 0; // Reseta a quantidade de engrenagens no cenário para 0

        // Acha todos as engrenagens no cenário e as insere no vetor (gears)
        gears = GameObject.FindGameObjectsWithTag("Gear");
        // Acha todos as engrenagens no inventário e as insere no vetor (gearsUI)
        gearsUI = GameObject.FindGameObjectsWithTag("UIGear");

        
        foreach (GameObject gear in gears) // Para cada engrenagem no vetor (gears)...
        {
            gear.SetActive(false); // uma engrenagem é desativada
        }

        
        foreach (GameObject gearUI in gearsUI) // Para cada engrenagem no vetor (gearsUI)...
        {
            gearUI.transform.GetChild(0).gameObject.SetActive(true); // uma engrenagem é ativada

            // o objeto (corInicial) recebe o componente da classe CorInicial de cada engrenagem
            corInicial = gearUI.transform.GetChild(0).gameObject.GetComponent<CorInicial>();
            // a engrenagem atual recebe sua cor inicial através da classe CorInicial
            gearUI.transform.GetChild(0).gameObject.GetComponent<Image>().color = corInicial.cor;
            
        }
    }
}
