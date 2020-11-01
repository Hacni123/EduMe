﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class playTwo : MonoBehaviour, playquestions
 {
	public string[] soal;
	public string[] jawaban;

	public Text text_soal, text_skor;
	public InputField input_jawaban;
    public UIManager uIManager;
	public GameObject feed_benar, feed_salah;

	int nomor_soal = -1;
    int skor=DBManager.score;
	public GameObject questionpanel3;
	public GameObject mez5;
	

	// Use this for initialization
	public void Start () 
	{
	    int skor=DBManager.score;
		buka_soal ();
	}

	public void buka_soal()
	{
		nomor_soal++;
		text_soal.text = soal [nomor_soal];
	}

	public void jawab()
	{
        Destroy(mez5);
		feed_benar.SetActive (false);
		feed_salah.SetActive (false);
		if (nomor_soal < soal.Length-1) {
			if (input_jawaban.text == jawaban [nomor_soal]) 
			{
				feed_benar.SetActive (true);
				feed_salah.SetActive (false);
				DBManager.score=DBManager.score+30;
				print(DBManager.score);
				Destroy(questionpanel3);	
			} else
			{
				feed_benar.SetActive (false);
				feed_salah.SetActive (true);
			}
			buka_soal ();
			input_jawaban.text = "";
		} else 
		{
			if(transform.childCount>=1)
			{
				transform.GetChild(transform.childCount-1).gameObject.SetActive (false);	
			}
			Destroy(questionpanel3);
			uIManager.OnGameOver(); 
		}
		if (SoundManager.instance != null)
            SoundManager.instance.PlayButtonPressSound();
	}
	
	
	
	// Update is called once per frame
	public void Update ()
	{
		text_skor.text = skor.ToString ();
	}
}
