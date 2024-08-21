using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableMaterial : MonoBehaviour, IDragHandler, IEndDragHandler
{

    public SpellManager spellManager;
    RectTransform rectTransform;
    Vector3 originalPos;
    private bool wasPaused = false;
    private PointerEventData currentPointerEventData;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPos = rectTransform.position;
    }

    void Update()
    {
        if (PauseManager.IsPaused)
        {
            wasPaused = true;
        }
        else if (wasPaused == true)
        {
            wasPaused = false;
            if (currentPointerEventData != null)
            {
                currentPointerEventData.pointerDrag = null;
            }
            rectTransform.position = originalPos;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {

        Vector3 globalMousePos;
        if (!PauseManager.IsPaused && RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out globalMousePos))
        {
            rectTransform.position = globalMousePos;
            currentPointerEventData = eventData;
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Vector3 globalMousePos;
        if (!PauseManager.IsPaused && RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out globalMousePos))
        {
            
            if (globalMousePos.x > -59.35 && globalMousePos.x < -54.85 && globalMousePos.y > -4.3 && globalMousePos.y < -1.2)
            {

                var type = "";

                if (name == "FireCrystal")
                {
                    type = "fire";

                } else if (name == "WaterCrystal")
                {
                    type = "water";

                }
                else if (name == "NatureCrystal")
                {
                    type = "nature";

                }
                else if (name == "AirCrystal")
                {
                    type = "air";

                }

                spellManager.changeSpellType(type);
            }

            rectTransform.position = originalPos;

        }
    }
}
