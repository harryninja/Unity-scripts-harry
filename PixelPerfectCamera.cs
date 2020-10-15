﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {
    public static float pixelTounits = 1f;
    public static float scale = 1f;

    public Vector2 nativeResolution = new Vector2 (240, 160);
    void Awake () {
        var camera = GetComponent<Camera> ();
        if (camera.orthographic) {
            scale = Screen.height / nativeResolution.y;
            pixelTounits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f / pixelTounits);
        }
    }

}