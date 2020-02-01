using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "TestComponentReference", menuName = "SO/TestComponent Reference", order = 1)]
[System.Serializable]
public class TestComponentReference : CrossSceneReferenceAsset<TestComponent> {
    public string GetName() {
        return target.name;
    }

}

public class TestComponent : MonoBehaviour
{

    public TestComponentReference asset;
    public CharaterReference character;


    private void Awake() {
        asset.SetReference(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(character.GetName());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
