using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBaner : MonoBehaviour {

	private string m_Key;
	private string m_Chanel;



	public ObjectBaner(string p_key, string p_Chanel){
		this.m_Key = p_key;
		this.m_Chanel = p_Chanel;
	}

	public string Key
	{
		get
		{
			return this.m_Key;
		}
		set
		{
			this.m_Key = value;
		}
	}

	public string Chanel
	{
		get
		{
			return this.m_Chanel;
		}
		set
		{
			this.m_Chanel = value;
		}
	}
		
}
