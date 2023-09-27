using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSpeech : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent OnButtonPressed;
    public UnityEvent OnButtonReleased;

    public Text txt;

    public void OnPointerDown(PointerEventData eventData)
    {
        txt.text = "Escuchanding...";
        OnButtonPressed?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        txt.text = " ";
        OnButtonReleased?.Invoke();
    }

}
