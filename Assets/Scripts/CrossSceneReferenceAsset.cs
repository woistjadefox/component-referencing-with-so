using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CrossSceneReferenceAsset<T> : ScriptableObject
{
    protected T target;

    public void SetReference(T target) {
        this.target = target;
    }

    public T GetReference() {
        return target;
    }

}
