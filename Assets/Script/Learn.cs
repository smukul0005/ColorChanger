using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Learn : MonoBehaviour
{
    public TextMeshProUGUI textmesh;
    public Image poster;
    public Sprite posterSprite;
    public Button small;
    public Button big;


    // Start is called before the first frame update
    void Start()
    {
        poster.color = Color.yellow;

    }

    public void buttonPress()
    {
        poster.sprite = posterSprite;

        textmesh.text = "own text";
        textmesh.color = Color.green;
        textmesh.fontSize = 10;
        poster.color = Color.white;

    }

    public void hideObject()
    {
        poster.gameObject.SetActive(false);
        //textmesh.gameObject.SetActive(false);
        small.gameObject.SetActive(false);
        big.gameObject.SetActive(false);
        textmesh.text = "hide";


    }

    public void showObject()
    {
        poster.gameObject.SetActive(true);
        //textmesh.gameObject.SetActive(true);
        small.gameObject.SetActive(true);
        big.gameObject.SetActive(true);
        textmesh.text = "show";
    }

    public void smallSize()
    {
        poster.rectTransform.localScale=new Vector3(0.5f,0.5f,0);
    }
    public void bigSize()
    {
        poster.rectTransform.localScale=new Vector3(1.5f,1.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
