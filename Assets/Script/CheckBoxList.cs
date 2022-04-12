using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoxList : MonoBehaviour
{   
    //[SerializeField] private ScrollContent _checkBoxPrefabs;
    public static CheckBoxList Instance;
    public GameObject _prefabs;
    public List<GameObject> _list = new List<GameObject>() ;
    public RectTransform _firstCheckBox;
    private void Awake() {
        if(Instance == null){
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }
    private void Start() {
        Vector3 currentPos = _firstCheckBox.transform.localPosition;

        for(int i = 1; i <= 10 ; i++){
            currentPos = new Vector3(currentPos.x , currentPos.y -60, currentPos.z);
            GameObject checkBox = Instantiate(_prefabs, currentPos ,Quaternion.identity);
            checkBox.SetActive(true);
            _list.Add(checkBox);
            //checkBox.GetComponent<ScrollContent>().SetText(i);
            checkBox.transform.SetParent(_prefabs.transform.parent, false);
        }
    }
}
