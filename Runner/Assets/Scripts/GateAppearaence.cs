using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class GateAppearaence : MonoBehaviour
{

   

    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

    


    public void UpdateVisual( int value)
    {
       

        if (value > 0)
        {
           
            SetColor(_colorPositive);
         
        } 
        else if (value == 0) 
        {
            SetColor(Color.grey);
        } 
        else
        {
            SetColor(_colorNegative);
           
        }

       
    }

    void SetColor(Color color) 
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }

}
