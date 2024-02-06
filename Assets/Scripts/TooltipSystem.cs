using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    private static TooltipSystem current;

    public Tooltip tooltip;

    private void Awake() 
    {
        current = this;
        Cursor.visible = true;
    }

    public static void Show(string content, string header = "")
    {
        current.tooltip.SetText(content, header);
        current.tooltip.gameObject.SetActive(true);
        Cursor.visible = false;
    }

    public static void Hide()
    {
        current.tooltip.gameObject.SetActive(false);
        Cursor.visible = true;
    }
}
