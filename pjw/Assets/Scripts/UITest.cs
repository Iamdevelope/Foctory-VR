using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITest : MonoBehaviour {
    private SteamVR_TrackedController pointer;
    private SteamVR_LaserPointer laserPointer;
    private void Start()
    {
        laserPointer.PointerIn += PointerIn;
        pointer.PadClicked += PadClicked;
    }

    private void PointerIn(object sender, PointerEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void PadClicked(object sender, ClickedEventArgs e)
    {
        throw new NotImplementedException();
    }
}
