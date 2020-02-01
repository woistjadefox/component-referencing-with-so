using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CharaterReference", menuName = "SO/Charater Reference", order = 1)]
[System.Serializable]
public class CharaterReference : CrossSceneReferenceAsset<Character> {
    public string GetName() {
        return target.name;
    }

}

public class Character : MonoBehaviour
{
    public CharaterReference asset;

    public TestComponentReference testComponent;

    private void Awake() {
        asset.SetReference(this);
    }

    private void Start() {
        Debug.Log(testComponent.GetReference().name);
    }
}
