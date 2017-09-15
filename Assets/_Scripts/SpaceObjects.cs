using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SpaceObjects : MonoBehaviour{
    
    //Class for storing objects retrived from NASA's website
    public Sprite img { get; set; }

    public string desc { get; set; }

    public SpaceObjects(Sprite img, string description)
    {
        this.img = img;
        desc = description;
    }
}
