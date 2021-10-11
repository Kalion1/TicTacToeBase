using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{
    
    //définition de l'enum (réutilisable par d'autres)
    public enum Content
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo = 2
    }
    
    // Variables de la classe
    public Content currentContent;
    GameCtrl myGame;
    
    // Start is called before the first frame update
    void Start()
    {
        myGame = FindObjectOfType<GameCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoverMe()
    {
        Debug.Log("I'm here", this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter me" + name, this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit me" + name, this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click me" + name, this);
        GetComponent<Image>().sprite = myGame.playerOneCheckbox;
        currentContent = Content.PlayerOne;
    }
}
