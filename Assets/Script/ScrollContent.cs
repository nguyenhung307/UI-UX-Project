using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScrollContent : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private int _currentIndex;
    private Toggle _toggle;
    private void Start() {
        _toggle = GetComponent<Toggle>();
    }
    public void SetText(int item){
        _text.text = "Item : " + item.ToString();
    }
}
