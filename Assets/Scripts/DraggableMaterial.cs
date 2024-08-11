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

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPos = rectTransform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {

        Vector3 globalMousePos;
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out globalMousePos))
        {
            rectTransform.position = globalMousePos;
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Vector3 globalMousePos;
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out globalMousePos))
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
