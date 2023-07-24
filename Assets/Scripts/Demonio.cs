using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demonio 
{
	private string m_name;
	private string m_description;
	private string m_abilities;
	private string m_specialties;
	private string m_status;
	private Sprite m_sprite;

	public Demonio(string t_name, string t_description, string t_abilities, string t_specialties, string t_status) {
		m_name = t_name;
		m_description = t_description;
		m_abilities = t_abilities;
		m_specialties = t_specialties;
		m_status = t_status;
	}

	public Demonio(string t_name, string t_description, string t_abilities, string t_status, Sprite t_sprite ) {
		m_name = t_name;
		m_description = t_description;
		m_abilities = t_abilities;
		m_abilities = t_status;
		m_sprite = t_sprite;
	}

	public string printDemonInfo(){
		return "Name: " + name + "\nDescription: " + description + "\nAbilities: " + abilities + "\nSpecialties: " + specialties + "\nStatus: " + status + "\n\n";
	}

	public string name{
		get{return m_name;} 
		set{m_name = value;}
	}

	public string description{
		get{return m_description;}
		set{m_description = value;}
	}

	public string abilities{
		get{return m_abilities;}
		set{m_abilities = value;}
	}

	public string specialties{
		get{return m_specialties;}
		set{m_specialties = value;}
	}

	public string status{
		get{return m_status;}
		set{m_status = value;}
	}
}
