using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropToInventory : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 posicaoInicial;

    [HideInInspector] public bool dropadoNoSlot;
    
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        // Salva a posição inicial da engrenagem em uma variável
        posicaoInicial = GetComponent<RectTransform>().localPosition;
    }

    public void OnBeginDrag(PointerEventData eventData) // No início do clique...
    {
        canvasGroup.alpha = 0.7f; // Deixa a engrenagem levemente transparente
        
        canvasGroup.blocksRaycasts = false; // Ativa a colisão da engrenagem, permitindo que ela colida com o slot

        dropadoNoSlot = false; // A engrenagem sai do slot

        ContadorGears.contaGear--; // A contagem de engrenagens nos slots diminui em 1
    }

    public void OnDrag(PointerEventData eventData) // Enquanto o botão do mouse permanece clicado...
    {
        // A engrenagem acompanha o cursor do mouse
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData) // No fim do clique...
    {
        canvasGroup.alpha = 1f; // A opacidade da engrenagem volta ao padrão

        canvasGroup.blocksRaycasts = true; // Desativa a colisão da engrenagem


        if (dropadoNoSlot) // Se a engrenagem foi solta no slot...
        {
            // Retorna a engrenagem para a posição inicial e desativa ela;
            this.rectTransform.localPosition = posicaoInicial;
            gameObject.SetActive(false);

        }
        else // Se a engrenagem não foi solta no slot...
        {
            // Retorna a engrenagem para a posição inicial;
            this.rectTransform.localPosition = posicaoInicial;
            ContadorGears.contaGear++;
        }
    }
}

