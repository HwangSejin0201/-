using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Original : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isBtnDown = false;
    public GameObject Hint;
    
    void start()
    {
        Hint.SetActive(false);
    }

    void Update()
    {
        if (isBtnDown) {
            Hint.SetActive(true);
        }
        else{
            Hint.SetActive(false);
        }
    }

    public void OnPointerDown (PointerEventData eventData)
    {
        isBtnDown=true;
    }

    public void OnPointerUp (PointerEventData eventData)
    {
        isBtnDown=false;
    }
}
