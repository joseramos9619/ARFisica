using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{   [Header("Cuestio")]
    [SerializeField] private ToggleGroup m_p1 = null;
    [SerializeField] private ToggleGroup m_p2 = null;
    [SerializeField] private ToggleGroup m_p3 = null;
    [SerializeField] private ToggleGroup m_p4 = null;
    [SerializeField] private ToggleGroup m_p5 = null;
    
    [Header("Alerta")]
     [SerializeField] private GameObject m_alertUi = null;
    [SerializeField] private Text m_text = null;

    string[] res=new string[5];
    string[] sol=new string[5] {"A","B","C","A","C"};

    Toggle GetSelectedToggle(ToggleGroup res)
    {
        Toggle[] toggles = res.GetComponentsInChildren<Toggle>();
        foreach (var t in toggles)
            if (t.isOn) return t; 
        return null;           
    }

    public void select()
    {
        Toggle p1 = GetSelectedToggle(m_p1);
        Toggle p2 = GetSelectedToggle(m_p2);
        Toggle p3 = GetSelectedToggle(m_p3);
        Toggle p4 = GetSelectedToggle(m_p4);
        Toggle p5 = GetSelectedToggle(m_p5);

        if (p1 != null & p2 != null & p3 != null & p4 != null & p5 != null)
        {
            int r=0;
            res[0]=p1.name;
            res[1]=p2.name;
            res[2]=p3.name;
            res[3]=p4.name;
            res[4]=p5.name;

            for(int i=0;i<5;i++){
                if(res[i]==sol[i]){
                    r++;
                }
            }
            m_alertUi.SetActive(true);
            m_text.text="Nota: "+r;
        }
        else
        {
            m_alertUi.SetActive(true);
            m_text.text = "Completar todas las preguntas";
        }
    }
    public void Cerrar(){
        m_alertUi.SetActive(false);
        m_text.text = "";
    }
}
