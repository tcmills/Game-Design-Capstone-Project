using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenRuneMenu : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject runesMenu;
    private AudioSource audioSource;
    public GameObject light1;
    public GameObject light2;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.Play();
        runesMenu.SetActive(true);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        light1.SetActive(true);
        light2.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        light1.SetActive(false);
        light2.SetActive(false);
    }
}
