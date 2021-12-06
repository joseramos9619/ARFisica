using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] private ToggleGroup m_p1 = null;
    [SerializeField] private ToggleGroup m_p2 = null;
    [SerializeField] private ToggleGroup m_p3 = null;
    [SerializeField] private ToggleGroup m_p4 = null;
    [SerializeField] private ToggleGroup m_p5 = null;
    [SerializeField] private Text m_text = null;

    Toggle GetSelectedToggle(ToggleGroup res)
    {
        Toggle[] toggles = res.GetComponentsInChildren<Toggle>();
        foreach (var t in toggles)
            if (t.isOn) return t;  //returns selected toggle
        return null;           // if nothing is selected return null
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
            m_text.text = p1.name+" "+p2.name+" "+p3.name+" "+p4.name+" "+p5.name;
        }
        else
        {
            m_text.text = "Completar todas las preguntas";
        }
    }
}
