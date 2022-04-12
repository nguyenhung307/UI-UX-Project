using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Scroll : MonoBehaviour
{
    public ScrollRect _scrollRect;
    public float _data;
    public float _spacing;
    public float _checkBoxHeight;
    public RectTransform _checkTop;
    public RectTransform _checkBot;
    private Vector2 _newAnchoredPosition = Vector2.zero;
    private List <RectTransform> listRect = new List<RectTransform>();

    private int _checkBoxCount;
    
    void Start()
    {
        _scrollRect = GetComponent<ScrollRect>();

        for(int i=0;i<_scrollRect.content.childCount;i++)
            {
                listRect.Add(_scrollRect.content.GetChild(i).GetComponent<RectTransform>());
            }
        //_content = GetComponent (typeof (RectTransform)) as RectTransform;
        _scrollRect.content.sizeDelta = new Vector2(  _scrollRect.content.sizeDelta.x, _data * (_spacing + _checkBoxHeight));
        Debug.Log(_scrollRect.content.sizeDelta);
         _checkBoxCount = _scrollRect.content.childCount;
    }

    void Update()
    {
        Debug.Log(_scrollRect.content.GetChild(0).transform.position.y);
        Check();  
    }

    public void Check(){

        for(int i = 0 ; i < listRect.Count; i++){
            if(_scrollRect.content.anchoredPosition.y > _checkTop.anchoredPosition.y){
                //Debug.Log("Move bottom");
                _newAnchoredPosition = listRect[i].anchoredPosition;
                _newAnchoredPosition.y -= _checkBoxCount * (_spacing + _checkBoxHeight);
                listRect[i].anchoredPosition = _newAnchoredPosition;
                _scrollRect.content.GetChild(_checkBoxCount - 1).transform.SetAsFirstSibling();
                
            }
            else if(_scrollRect.content.anchoredPosition.y < _checkBot.anchoredPosition.y){
                
                //Debug.Log("Move top");
                _newAnchoredPosition = listRect[i].anchoredPosition;
                _newAnchoredPosition.y += _checkBoxCount * (_spacing + _checkBoxHeight);
                listRect[i].anchoredPosition = _newAnchoredPosition;
                _scrollRect.content.GetChild(0).transform.SetAsLastSibling();
   
            }
        }
    }
    // private void SetItems () 
    // { 
    //     listRect.Clear (); 
    //     for (int i = 0; i <_scrollRect.content.childCount; i ++) 
    //     { 
    //     listRect.Add (_scrollRect.content.GetChild (i) .GetComponent <RectTransform> ()); 
    //     } 
    // }
}
