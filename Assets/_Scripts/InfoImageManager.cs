using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoImageManager : MonoBehaviour {

    public Image currentImage;
    public Text currentText;

    Object[] images;

    string[] desc;

    List<SpaceObjects> spaceObjects;

    int currentIndex;

    // Use this for initialization
	void Start () {
        images = Resources.LoadAll("Images", typeof(Sprite));
        desc = new string[images.Length];
        spaceObjects = new List<SpaceObjects>();

        desc[1] = "What should you do if your rock climbing picture " +
            "is photobombed by a total eclipse of the Sun? Rejoice -- because your planning paid off.";
        desc[0] = " Last week, for a fraction of a second, the Sun was eclipsed twice. One week ago today, many people in North America were treated to a standard, single, partial solar eclipse. Fewer people, " +
            "all congregated along a narrow path, experienced the eerie daytime darkness of a total solar eclipse. ";
        desc[2] = "What are those spots on Jupiter? Largest and furthest, just right of center, is the Great Red Spot -- a huge storm system that has been raging on Jupiter possibly " +
            "since Giovanni Cassini's likely notation of it 352 years ago. It is not yet known why this Great Spot is red.";
        desc[3] = "What's happening over the water? Pictured here is one of the better images yet recorded of a waterspout, a type of tornado that occurs over water." +
            " Waterspouts are spinning columns of rising moist air that typically form over warm water. ";

        spaceObjects = new List<SpaceObjects>();
        for (int i = 0; i < images.Length; i++)
        {
            spaceObjects.Add(new SpaceObjects((Sprite)images[i], desc[i]));
        }




        currentIndex = 0;
        currentImage.sprite = spaceObjects[currentIndex].img;
        currentText.text =    spaceObjects[currentIndex].desc;

    }
	
	// Update is called once per frame
	void Update () {
		
        
	}

    public void NextImage()
    {
        currentIndex++;
        if (currentIndex == images.Length)
            currentIndex = 0;

        currentImage.sprite = spaceObjects[currentIndex].img;
        currentText.text = spaceObjects[currentIndex].desc;
    }

    public void PreviousImage()
    {
        currentIndex--;
        if (currentIndex < 0)
            currentIndex = images.Length - 1;

        currentImage.sprite = spaceObjects[currentIndex].img;
        currentText.text = spaceObjects[currentIndex].desc;

    }
}
