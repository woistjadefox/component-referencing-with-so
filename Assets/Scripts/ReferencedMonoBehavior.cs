using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ReferencedMonoBehavior<T> : MonoBehaviour
{
    [System.Serializable]
    public class Reference : CrossSceneReferenceAsset<T> {}

    public Reference asset;

   
}
