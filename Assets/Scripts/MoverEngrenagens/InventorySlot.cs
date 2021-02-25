using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) 
    {
        if(eventData.pointerDrag != null) // Se a engrenagem colidiu com o slot quanto foi solta...
        {
            if(!transform.GetChild(0).gameObject.activeInHierarchy) // Se ainda não houver uma engrenagem no slot...
            {
                
                if (eventData.pointerDrag.gameObject.tag == "Gear") // Se for uma engrenagem do mundo...
                {
                    /* Ativa o boolean dropadoNoSlot ( assim desativando a engrenagem que foi arrastada através do 
                       script DragDropToInventory ) */
                    eventData.pointerDrag.GetComponent<DragDropToInventory>().dropadoNoSlot = true;
                    
                    // A cor da engrenagem se torna a mesma cor da engrenagem do mundo
                    transform.GetChild(0).gameObject.GetComponent<Image>().color =
                    eventData.pointerDrag.GetComponent<DragDropToInventory>().GetComponent<Image>().color;
                }
                else // Se for uma engrenagem do próprio inventário
                {
                    /* Ativa o boolean dropadoNoSlot ( assim desativando a engrenagem que foi arrastada através do 
                       script DragDropToWorld ) */
                    eventData.pointerDrag.GetComponent<DragDropToWorld>().dropadoNoSlot = true;
                    
                    // A cor da engrenagem se torna a mesma cor da engrenagem do inventário
                    transform.GetChild(0).gameObject.GetComponent<Image>().color =
                    eventData.pointerDrag.GetComponent<DragDropToWorld>().GetComponent<Image>().color;
                }
                // A engrenagem do slot é ativada
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}

 
