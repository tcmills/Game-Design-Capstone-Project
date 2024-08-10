using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableMaterial : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {

        var rectTransform = GetComponent<RectTransform>();
        Vector3 globalMousePos;
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out globalMousePos))
        {
            rectTransform.position = globalMousePos;
            //rectTransform.position = new Vector3(globalMousePos.x, globalMousePos.y, 0);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
