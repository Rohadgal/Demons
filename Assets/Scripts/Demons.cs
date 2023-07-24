using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Demons{
	public abstract void SetName(string t_name);
	//public abstract void SetDescription(string t_description);
	//public abstract void SetAbilities(string t_abilities);
	public abstract void SetSpecialties(string t_specialties);
	//public abstract void SetStatus(string t_status);
	public abstract string GetName();
	public abstract string GetDescription();
	public abstract string GetAbilities();
	public abstract string GetSpecialties();
	public abstract string GetStatus();
}

public class InterfaceDemons : Demons{
	private string m_name;
	private string m_description;
	private string m_abilities;
	private string m_specialties;
	private string m_status;


	public override void SetName(string t_name){
		m_name = t_name;
	}

	public override void SetSpecialties(string t_specialties){
		m_specialties = t_specialties;
	}

	public override string GetName(){
		return m_name;
	}

	public override string GetDescription(){
		return m_description;
	}

	public override string GetAbilities(){
		return m_abilities;
	}

	public override string GetSpecialties(){
		return m_specialties;
	}

	public override string GetStatus(){
		return m_status;
	}
	
	public InterfaceDemons(string t_name, string t_description, string t_abilities, string t_specialties, string t_status) {
		m_name = t_name;
		m_description = t_description;
		m_abilities = t_abilities;
		m_specialties = t_specialties;
		m_status = t_status;
	}
}
