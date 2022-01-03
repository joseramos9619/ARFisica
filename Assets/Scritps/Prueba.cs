using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prueba : MonoBehaviour
{
    [Header("Preguntas")]
    [SerializeField] private Image m_pre1 = null;
    [SerializeField] private Image m_pre2 = null;
    [SerializeField] private Image m_pre3 = null;
    [SerializeField] private Image m_pre4 = null;
    [SerializeField] private Image m_pre5 = null;

    [Header("Interfaz")]
    [SerializeField] private GameObject m_opcion = null;
    [SerializeField] private GameObject m_exame = null;
    [SerializeField] private GameObject m_barExame = null;
    [SerializeField] private GameObject m_guia = null;
    [SerializeField] private GameObject m_scan = null;
    [SerializeField] private GameObject m_fondo = null;
    [SerializeField] private GameObject m_alertUi = null;
    [SerializeField] private Text m_text = null;

    [Header("Respuestas")]
    [SerializeField] private ToggleGroup m_p1 = null;
    [SerializeField] private ToggleGroup m_p2 = null;
    [SerializeField] private ToggleGroup m_p3 = null;
    [SerializeField] private ToggleGroup m_p4 = null;
    [SerializeField] private ToggleGroup m_p5 = null;

    int num = 0;
    string[] res = new string[5];
    string[,] sol = new string[4,5] {{ "A", "B", "C", "A", "C" },
                                     { "A", "B", "C", "A", "C" },
                                     { "A", "B", "C", "A", "C" },
                                     { "A", "B", "C", "A", "C" }};

    public void Guia()
    {
        m_exame.SetActive(false);
        m_guia.SetActive(true);
        m_barExame.SetActive(false);
    }

    public void Exame()
    {
        m_exame.SetActive(false);
        m_opcion.SetActive(true);
        m_barExame.SetActive(false);
    }

    public void cargar(int opc)
    {   num = opc;
        if (opc == 1)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

        if (opc == 2)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

        if (opc == 3)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

        if (opc == 4)
        {
            m_pre1.sprite = Resources.Load<Sprite>("Preguntas/1");
            m_pre2.sprite = Resources.Load<Sprite>("Preguntas/2");
            m_pre3.sprite = Resources.Load<Sprite>("Preguntas/3");
            m_pre4.sprite = Resources.Load<Sprite>("Preguntas/4");
            m_pre5.sprite = Resources.Load<Sprite>("Preguntas/5");
            m_exame.SetActive(true);
            m_opcion.SetActive(false);
            m_barExame.SetActive(true);
        }

    }

    Toggle GetSelectedToggle(ToggleGroup res)
    {
        Toggle[] toggles = res.GetComponentsInChildren<Toggle>();
        foreach (var t in toggles)
            if (t.isOn) return t;
        return null;
    }

    public void desmarcar(ToggleGroup s)
    {
        Toggle[] toggles = s.GetComponentsInChildren<Toggle>();
        foreach (var t in toggles)
        {
            if (t.isOn)
            {
                t.isOn = false;
            }
        }
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
            int r = 0;
            
            res[0] = p1.name;
            res[1] = p2.name;
            res[2] = p3.name;
            res[3] = p4.name;
            res[4] = p5.name;

            for (int i = 0; i < 5; i++)
            {
                if (res[i] == sol[(num-1),i])
                {
                    r++;
                }
            }
            m_alertUi.SetActive(true);
            m_text.text = "Nota: " + r;
        }
        else
        {
            m_alertUi.SetActive(true);
            m_text.text = "Completar todas las preguntas";
        }
    }

    public void Cerrar()
    {
        m_alertUi.SetActive(false);
        m_text.text = "";
    }

}
