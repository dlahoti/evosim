﻿using UnityEngine;
using System.Collections;

public class UIElement : MonoBehaviour {
    public void make_invisible()
    {
        CanvasGroup cg = GetComponent<CanvasGroup>();
        cg.interactable = false;
        cg.blocksRaycasts = false;
        cg.alpha = 0;
    }

    public void make_visible()
    {
        CanvasGroup cg = GetComponent<CanvasGroup>();
        cg.interactable = true;
        cg.blocksRaycasts = true;
        cg.alpha = 1;
    }

}
