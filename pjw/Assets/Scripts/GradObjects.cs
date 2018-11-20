using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class GradObjects : VRTK_InteractableObject {

    protected override Transform CreateAttachPoint(string namePrefix, string nameSuffix, Transform origin)
    {
        Transform attachPoint = new GameObject(VRTK_SharedMethods.GenerateVRTKObjectName(true, namePrefix, nameSuffix, "Controller", "AttachPoint")).transform;
        attachPoint.parent = transform;
        Vector3 pos = origin.position;
        pos.z = 10;
        attachPoint.position = pos;
        attachPoint.rotation = origin.rotation;
        return attachPoint;
    }
}
