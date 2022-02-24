using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviour
{
    [SerializeField]
    private GameObject body;

    [SerializeField]
    private Texture[] textures;

    private Renderer bodyRenderer;
    
    private int randomTextureIndex;

    // Start is called before the first frame update
    void Start()
    {
        bodyRenderer = body.GetComponentInChildren<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeSphereTexture);
    }

    
    private void ChangeSphereTexture()
    {
        randomTextureIndex = Random.Range(0, textures.Length);
        bodyRenderer.material.mainTexture = textures[randomTextureIndex];
    }
}
