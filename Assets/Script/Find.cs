using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Find : MonoBehaviour
{
    public int _numberInput;

    public InputField _inputField;

    public int _heightContent;
    private void Start()
    {
        _heightContent = 10000 * (50 + 10);
    }
    private void Update()
    {
        _numberInput = int.Parse(_inputField.text);
    }

    public int Search()
    {
        int _numberOutput = _heightContent / _numberInput;
        return _numberOutput;
    }

}
