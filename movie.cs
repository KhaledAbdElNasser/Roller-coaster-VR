using UnityEngine;
using System.Collections;

public class movie : MonoBehaviour {


    public MovieTexture movTexture;
    public AudioSource MOVIESOUND;
    public bool picture360;
    public bool video360;
    // Use this for initialization
    void Start () {
        this.GetComponent<Renderer>().material.mainTexture = movTexture;
        
        this.MOVIESOUND = GetComponent < AudioSource >();
        this.MOVIESOUND.clip = movTexture.audioClip;
        if (video360 == true) {
            this.PlayVideo();
        }
        if (picture360 == true)
        {
            this.PlayVideoWithoutVoice();
        }

        Debug.Log(movTexture.duration);
        
    }
	
    public void PlayVideo()
    {
        if(this.MOVIESOUND == null)
        {
            this.MOVIESOUND = GetComponent<AudioSource>();
            this.MOVIESOUND.clip = this.movTexture.audioClip;
        }
        this.movTexture.Play();

		this.MOVIESOUND.Play();
		this.movTexture.loop = true;
        this.MOVIESOUND.loop = true;
    }

    public void PauseVideo()
    {
        this.movTexture.Pause();
        this.MOVIESOUND.Pause();
        
    }
    public void PlayVideoWithoutVoice()
    {
        this.movTexture.loop = true;
        this.movTexture.Play();
        if(MOVIESOUND)
        {
            this.MOVIESOUND.Stop();
        }
        
    }
    public void StopVideo()
    {
        this.movTexture.Stop();
        this.MOVIESOUND.Stop();
        

    }

    // Update is called once per frame
    void Update () {
   }
}
