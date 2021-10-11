using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour,IPointerClickHandler
{
    
    
    GameCtrl myGame;
    public int ID;
    bool canClick;
    
    // Start is called before the first frame update
    void Start()
    {
        myGame = FindObjectOfType<GameCtrl>();
        canClick = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!canClick) return;
        if (myGame.currentContent == GameCtrl.Content.Victory || myGame.currentContent == GameCtrl.Content.Defeat) return;
        canClick = false;
        
        if (myGame.currentContent == GameCtrl.Content.PlayerOne)
        {
            GetComponent<Image>().sprite = myGame.playerOneCheckbox;
            //myGame.currentContent = GameCtrl.Content.PlayerTwo;
        }
        else if (myGame.currentContent == GameCtrl.Content.PlayerTwo)
        {
            GetComponent<Image>().sprite = myGame.playerTwoCheckbox;
            //myGame.currentContent = GameCtrl.Content.PlayerOne;
        }
        myGame.changePlayer(ID);
        
    }
}
