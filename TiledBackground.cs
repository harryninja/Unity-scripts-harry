using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiledBackground : MonoBehaviour {
    public int textureSize = 32;
    void Start () {
        var newWidth = Mathf.Ceil (Screen.width / (textureSize * PixelPerfectCamera.scale));
        var newHeight = Mathf.Ceil (Screen.height / (textureSize * PixelPerfectCamera.scale));

        transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize, 1);

        GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight, 1);
    }

    // Update is called once per frame
    void Update () {

    }
}