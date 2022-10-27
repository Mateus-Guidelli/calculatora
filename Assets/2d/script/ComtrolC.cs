using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class ComtrolC : MonoBehaviour
{
    [SerializeField] private Text textI;
    [SerializeField] private Text textII;
    

    private string _expression;
    
    void Start()
    {
        textI.text = "";
        textII.text = "";
    }

    public void BtnCharacter(string character)
    {
        textII.text = character;
        textI.text = textI.text + textII.text;
        
    }

    public void ExpressionCalculator()
    {
        
        _expression = textI.text;
        DataTable table = new  DataTable("tabela");
        string _result = table.Compute(_expression, string.Empty).ToString();
        textII.text = _result;
        
    }

    public void Clear()
    {
        textI.text = "";
        textII.text = "";
        
    }


    
}
