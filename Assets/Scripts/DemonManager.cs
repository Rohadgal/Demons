using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DemonManager : MonoBehaviour{   

    InterfaceDemons[] demons = new InterfaceDemons[10];
    int demonIndex = 0;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text abilitiesText;
    public TMP_Text specialtiesText;
    public TMP_Text statusText;

    void Start(){
        /*
	    Demonio primerDemonio = new Demonio("Bael", "Primer rey del infierno. Asistente personal de Satanás", "Puede hacer invisible e inteligente a quien lo invoca", "Preguntas" ,"Rey");
	    Demonio segundoDemonio = new Demonio("Vassago", "Demonio de buena naturaleza", "Puede desocultar hechizos que han sido ocultados", "Magia, Futuro", "Príncipe");
	    Demonio tercerDemonio = new Demonio("Valefor", "Experto en medicina oculta", "Es capaz de curar todos los males", "Salud", "Duque");
	    Demonio cuartoDemonio = new Demonio("Buer", "Demonio del instinto", "Enseña filosfía moral y natural y lógica y virtudes de las hierbas", "Vicios, Conocimiento y Salud", "Presidente" );
        Demonio quintoDemonio = new Demonio("Gusion", "Tiene conocimiento de hechos pasados y futuros", "Reconcilia amigos", "Preguntas, Futuro", "Duque");
        
       print(primerDemonio.printDemonInfo());
       print(segundoDemonio.printDemonInfo());
       */

        demons[0] = new InterfaceDemons("Bael", "Primer rey del infierno. Asistente personal de Satanás", "Puede hacer invisible e inteligente a quien lo invoca", "Preguntas" ,"Rey");
	    demons[1] = new InterfaceDemons("Vassago", "Demonio de buena naturaleza", "Puede desocultar hechizos que han sido ocultados", "Magia, Futuro", "Príncipe");
	    demons[2] = new InterfaceDemons("Valefor", "Experto en medicina oculta", "Es capaz de curar todos los males", "Salud", "Duque");
	    demons[3] = new InterfaceDemons("Buer", "Demonio del instinto", "Enseña filosfía moral y natural y lógica y virtudes de las hierbas", "Vicios, Conocimiento y Salud", "Presidente" );
        demons[4] = new InterfaceDemons("Gusion", "Tiene conocimiento de hechos pasados y futuros", "Reconcilia amigos", "Preguntas, Futuro", "Duque");
        demons[5] = new InterfaceDemons("Leraje", "Es muy útil en dirigir los objetivos deseados y hacerlos realidad", "Contesta causas y batallas y puede causar lesiones, infeccions  e impedir cicatrización", "Amor, Militar", "Marqués");
        demons[6] = new InterfaceDemons("Eligos", "Tiene conocimienyod dontr lo oculto", "Puede revelar secretos en general y magias ocultas", "Ley", "Duque");
        demons[7] = new InterfaceDemons("Purson", "Sabe la localización de objetos y tesoros ocultos", "Es un espíritu de adivinación que permite la comunicación con los muertos", "Necromancia", "Rey");
        demons[8] = new InterfaceDemons("Foras", "Enseña lógica y ética en todas sus ramas", "Puede hacer al hombre ingenioso, elocuente, invisible y vivir mucho", "Conocimiento, Dinero, Fuerza, Invisibilidad", "Presidente");
        demons[9] = new InterfaceDemons("Belial", "Demonio del vicio y el goce por el goce", "Distribuye altos cargos y causa el favor de amigos y enemigos, concede espíritus familiares excelentes", "Preguntas, Trabajo", "Rey");
       
       changeDemonInfo();
      
    }

    void Update(){
        
    }

    public void changeDemon(){
        demonIndex++;
        if(demonIndex < demons.Length-1){
            changeDemonInfo();
        }
        else{
            demonIndex = 0;
            changeDemonInfo();
        }
    }

    void changeDemonInfo(){
        nameText.text = demons[demonIndex].GetName();
       descriptionText.text = demons[demonIndex].GetDescription();
       abilitiesText.text = demons[demonIndex].GetAbilities();
       specialtiesText.text = demons[demonIndex].GetSpecialties();
       statusText.text = demons[demonIndex].GetStatus();
    }
}
