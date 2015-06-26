using UnityEngine;
using System.Collections;

public class Start_level : MonoBehaviour {
	public AudioClip audio_clip;
	public AudioSource audio_source;
	private float start;
	// Use this for initialization
	void Start () {
		Cursor.visible  = false;
		audio_source.clip = audio_clip;
		Play ();
		start = Time.time;
	}
	void Update()
	{
		if (start + audio_clip.length < Time.time) {
			Stop();
			Play ();
			start = Time.time;
		}
	}
	// Update is called once per frame
	public void increment_volume()
	{
		audio_source.volume =+ 0.1f;
	}
	public void decrement_volume()
	{
		audio_source.volume = audio_source.volume - 0.1f;
	}
	public void set_volume(float val)
	{
		audio_source.volume = val;
	}
	public void Play()
	{
		audio_source.Play ();
	}
	public void Mute_and_Unmute()
	{
		audio_source.mute = !audio_source.mute;
	}
	public void Stop()
	{
		audio_source.Stop ();
	}
}
