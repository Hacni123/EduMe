using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class SwitchCharacter : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject prev;
    public GameObject next;
    private GameObject[] characterList;
    private int index;
    void Start()
    {
        index= PlayerPrefs.GetInt("CharacterSelected");
        characterList= new GameObject[transform.childCount];
        for(int i=0; i<transform.childCount; i++)
            characterList[i]=transform.GetChild(i).gameObject;

            foreach(GameObject go in characterList)
                  go.SetActive(false);

            if(characterList[index])
               characterList[index].SetActive(true);
    }

    public void ToggleLeft()
    {
        characterList[index].SetActive(false);
        index--;
        if(index <0)
        {
            index=characterList.Length-1;
            characterList[index].SetActive(true);
        }
    }

    public void ToggleRight()
    {
        characterList[index].SetActive(false);
        index++;
        if(index == characterList.Length);
        index=0;
            characterList[index].SetActive(true);
        
    }

    // Update is called once per frame
    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        level1.SetActive(true);
        level2.SetActive(true);
        level3.SetActive(true);
        level4.SetActive(true);
        characterList[index].SetActive(true);
        prev.SetActive(false);
        next.SetActive(false);
         
    }
}
