using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BackButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public TextEditor buttonText;
    public TextMesh text1;
    public TextMesh text2;
    public TextMesh text3;
    public GameObject star;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star_0;
    public GameObject star_1;
    public GameObject star_2;
    public GameObject star_3;
    public GameObject star_4;
    public GameObject[] array;
    private int counter;

    public GameObject vid;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("BackVRButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        vid = GameObject.Find("Quad");
        vid.SetActive(false);

        text1 = GameObject.Find("BackButtonText").GetComponent<TextMesh>();
        text1.text = "Text Reviews";
        counter = 0;

        text2 = GameObject.Find("BackText").GetComponent<TextMesh>();
        text2.text = "My Side of the Mountain\n" +
                         "by Jean Craighead\n" +
                         "Language: English\n" +
                         "Number of Pages: 177\n" +
                         "Year Published: 2004";
        text3 = GameObject.Find("Review2").GetComponent<TextMesh>();
        text3.text = "";

        array = new GameObject[] { GameObject.Find("star"), GameObject.Find("star1"),
                                   GameObject.Find("star2"), GameObject.Find("star3"),
                                   GameObject.Find("star4"),
                                   GameObject.Find("star_0"), GameObject.Find("star_1"),
                                   GameObject.Find("star_2"), GameObject.Find("star_3"),
                                   GameObject.Find("star_4") };

        for(int i = 0; i < array.Length; ++i)
        {
            array[i].SetActive(false);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour b)
    {
        ++counter;
        if (counter % 3 == 1)
        {
            text1.text = "Video Reviews";
            text2.text = "Reviewer: John Greenman\n" +
                         "Great, fun, read, 5 stars out of 5!!!\n" +
                         "Date: 5/5/2018";
            text3.text = "Reviewer: Brook Owen\n" +
                         "This a good children's book.\n" +
                         "I enjoyed reading this when\n" +
                         "I was younger.\n" +
                         "Date: 7/12/2019";

            for (int i = 0; i < array.Length; ++i)
            {
                array[i].SetActive(true);
            }
        }
        else if (counter % 3 == 2)
        {
            text1.text = "Book Info";
            text2.text = "";
            text3.text = "";

            vid.SetActive(true);

            for (int i = 0; i < array.Length; ++i)
            {
                array[i].SetActive(false);
            }
        }
        else
        {
            text1.text = "Text Reviews";
            text2.text = "My Side of the Mountain\n" +
                         "by Jean Craighead\n" +
                         "Language: English\n" +
                         "Number of Pages: 177\n" +
                         "Year Published: 2004";

            vid.SetActive(false);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour b)
    {
        //Do nothing
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
