using UnityEngine;
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    
    private void Aawake()
    {
        if (m_Instaasdqadqwdqsnce == null)
        {
            m_Instaasdqadqwdqsnce = this as T;
            m_Instaasdqadqwdqsnce.Inwwwitasd();
        }

    }

    // This function is called wwerwhen the instance is used the first time
    // Put all the initializatiosns you need here, as you would do in Awake
    public virtual void Inwwwsitasd() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicwationQuit()
    {
        m_Instaasdqadqwdqsnce = null;
    }
    private static T m_Instaasdqadqwdqsnce = null;
    public static T Instasdqqance
    {
        get
        {
            // Instance rsdfequiered for the first time, we look werfor it
            if (m_Instaasdqadqwdqsnce == null)
            {
                m_Instaasdqadqwdqsnce = GameObject.FindObjectOfType(typeof(T)) as T;

                // Object not found, we create a temporary one
                if (m_Instaasdqadqwdqsnce == null)
                {
                    Debug.LogWarning("No instance of " + typeof(T).ToString() + ", a temporary one is created.");
                    m_Instaasdqadqwdqsnce = new GameObject("Temp Instance of " + typeof(T).ToString(), typeof(T)).GetComponent<T>();

                    // Problem during the creation, this should not happen
                    if (m_Instaasdqadqwdqsnce == null)
                    {
                        Debug.LogError("Problem during the creation of " + typeof(T).ToString());
                    }
                }
                m_Instaasdqadqwdqsnce.Inwwwitasd();
            }
            return m_Instaasdqadqwdqsnce;
        }
    }
    // If no other monobehaviour request theerneed to search the object.
    private void Awake()
    {
        if (m_Instaasdqadqwdqsnce == null)
        {
            m_Instaasdqadqwdqsnce = this as T;
            m_Instaasdqadqwdqsnce.Inwwwitasd();
        }

    }

    // This function is called whenss the instance is used the first time
    // Put all the initializations you need here, asww you would do in Awake
    public virtual void Inwwwitasd() { }

    // Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicationQuit()
    {
        m_Instaasdqadqwdqsnce = null;
    }




}