using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information : MonoBehaviour
{
    public GameObject Info_Kunyit; 
    public GameObject Info_Jahe; 
    public GameObject Info_Temulawak;
    public GameObject Info_Lemon; 
    public GameObject Info_Serai; 

    void Start() {
        Info_Kunyit.gameObject.SetActive(false);
        Info_Jahe.gameObject.SetActive(false);
        Info_Temulawak.gameObject.SetActive(false);
        Info_Lemon.gameObject.SetActive(false);
        Info_Serai.gameObject.SetActive(false);

    }
   public void activeInfo_Kunyit(){
        Info_Kunyit.gameObject.SetActive(true);

   }
      public void activeInfo_Jahe(){
        Info_Kunyit.gameObject.SetActive(true);

   }
      public void activeInfo_Temulawak(){
        Info_Kunyit.gameObject.SetActive(true);

   }
      public void activeInfo_Lemon(){
        Info_Kunyit.gameObject.SetActive(true);

   }
      public void activeInfo_Serai(){
        Info_Kunyit.gameObject.SetActive(true);

   }
   public void CloseInfo(){

   }
}
