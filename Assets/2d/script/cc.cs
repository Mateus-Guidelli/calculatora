using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;


public class cc : MonoBehaviour
{
    [SerializeField] private Text textI2;
    [SerializeField] private Text textII2;
    

    private string _expression2;
    
    void Start()
    {
        textI2.text = "";
        textII2.text = "";
    }

    public void BtnCharacter(string character)
    {
        textII2.text = character;
        textI2.text = textI2.text + textII2.text;
        
    }

    public void ExpressionCalculator()
    {
        
        _expression2 = textI2.text;
        DataTable table2 = new  DataTable("tabela2");
        string _result2 = table2.Compute(_expression2, string.Empty).ToString();
        textII2.text = _result2;
        
    }

    public void Clear()
    {
        textI2.text = "";
        textII2.text = "";
        
    }
}
