using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [Header("login")]
    [SerializeField] private InputField m_loginUserInput = null;
    [SerializeField] private InputField m_loginPassInput = null;
    [SerializeField] private Text m_mensUser = null;
    [SerializeField] private GameObject m_conteUi = null;

    [Header("Registro")]
    [SerializeField] private GameObject m_loginUi = null;
    [SerializeField] private GameObject m_registerUi = null;
    [SerializeField] private InputField m_userInput = null;
    [SerializeField] private InputField m_emailInput = null;
    [SerializeField] private InputField m_passInput = null;
    [SerializeField] private InputField m_veripassInput = null;
    [SerializeField] private Text m_mens = null;

    private Netword m_netword = null;

    private void Awake()
    {
        m_netword = GameObject.FindObjectOfType<Netword>();
    }
    
    public void limpiar(){
        m_loginUserInput.text="";
        m_loginPassInput.text="";
        m_userInput.text="";
        m_passInput.text="";
        m_emailInput.text="";
        m_veripassInput.text="";
        m_userInput.text="";
        m_mens.text="";
    }

    public void cancelar(){
        limpiar();
        veruserui();
    }

    public void salir(){
        limpiar();
        m_loginUi.SetActive(true);
        m_conteUi.SetActive(false);
    }

    public void verregisterui()
    {
        m_loginUi.SetActive(false);
        m_registerUi.SetActive(true);
    }

    public void veruserui()
    {
        m_loginUi.SetActive(true);
        m_registerUi.SetActive(false);
    }

    public void vercont(){
        m_loginUi.SetActive(false);
        m_registerUi.SetActive(false);
        m_conteUi.SetActive(true);
    }

    public void Ingresar()
    {
        if (m_loginUserInput.text == "" || m_loginPassInput.text == "")
        {
            m_mens.text = "Por favor llene todos los campos";
            return;
        }
        m_mens.text = "Procesando...";

        m_netword.Validar(m_loginUserInput.text, m_loginPassInput.text, delegate (Response response)
        {
            m_mens.text = "Biembenido: "+response.mens;

            if(m_loginUserInput.text==response.mens){
                m_mensUser.text= "Usuario: "+response.mens;
                vercont();
                limpiar();
            }
        });
    }

    public void Registrar()
    {
        if (m_userInput.text == "" || m_emailInput.text == "" || m_passInput.text == "" || m_veripassInput.text == "")
        {
            m_mens.text = "Por favor llene todos los campos";
            return;
        }

        if (m_passInput.text == m_veripassInput.text)
        {
            m_mens.text = "Procesando...";

            m_netword.Guardar(m_userInput.text, m_emailInput.text, m_passInput.text, delegate (Response response)
            {
                m_mens.text = response.mens;
            if (m_mens.text == "Registro Exitoso")
            {
                veruserui();
                limpiar();
            }
            });
        }
        else
        {
            m_mens.text = "La contraseña no coinside";
        }
    }
}
