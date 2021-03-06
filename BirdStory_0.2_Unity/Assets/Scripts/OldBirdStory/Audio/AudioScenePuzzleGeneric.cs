using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScenePuzzleGeneric: MonoBehaviour 
{
   [Header("Buttons")]

    public Button BackBtn;
    public Button PauseBtn;
    public Button ToggleLevelPuz1;
	public Button ToggleLevelPuz2;
	public Button ToggleLevelPuz3;
    public Button ResetItemBtn;

    [Header("Music")]

    [FMODUnity.EventRef]
    public string sceneMusicEvent;
    public FMOD.Studio.EventInstance sceneMusic;

    [FMODUnity.EventRef]
    public string transEvent = "event:/SFX/SFX_General/TransitionsSound";
    public FMOD.Studio.EventInstance transMusic;

    [Header("Eggs")]
    [FMODUnity.EventRef]
    public string silverEggClickEvent = "event:/SFX/SFX_General/Egg_Click_Silver";
    public FMOD.Studio.EventInstance silverEggClickSound;

    [FMODUnity.EventRef]
    public string silverEggTrailEvent = "event:/SFX/SFX_General/FX_trail";
    public FMOD.Studio.EventInstance silverEggTrailSound;


    public string buttonEvent = "event:/SFX/SFX_General/Button";
    public FMOD.Studio.EventInstance buttonSound;

    [Header("Puzzle completino")]
    [FMODUnity.EventRef]
    public string puzPieceEvent = "event:/SFX/ANIMS/Puzzle Completed/puzzlePieces";
    public FMOD.Studio.EventInstance puzPieceSound;

    [FMODUnity.EventRef]
    public string puzPieceJingleEvent = "event:/SFX/ANIMS/Puzzle Completed/puzzleTextJingle";
    public FMOD.Studio.EventInstance puzPieceJingleSound;


    ////////////
    public AudioHelperBird audioHelperBirdScript;

    public virtual void PlaySceneMusic()
    {
        sceneMusic.start();
    }

    public virtual void StopSceneMusic()
    {
        sceneMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    void Start(){
    }

    void Update(){}

     public virtual void Transition()
    {
        //puzzle button sound
        buttonSFX();

        //stop current music
        StopSceneMusic();
        Debug.Log("Current Music Stopped :");
		transMusic.start();
		PlayTransitionMusic();

    }
	
	public virtual void PlayTransitionMusic()
    {
        transMusic.start();
    }

      public void silverEggSnd()
    {
       silverEggClickSound = FMODUnity.RuntimeManager.CreateInstance(silverEggClickEvent);
       silverEggClickSound.start();
    }

	public void SilverEggTrailSFX () 
	{
		silverEggTrailSound = FMODUnity.RuntimeManager.CreateInstance(silverEggTrailEvent);
        silverEggTrailSound.start();
	}

    public virtual void buttonSFX()
    {
        //button sound
        buttonSound = FMODUnity.RuntimeManager.CreateInstance(buttonEvent);
        buttonSound.start();
    }

        public virtual void puzPieceSnd()
    {
        puzPieceSound = FMODUnity.RuntimeManager.CreateInstance(puzPieceEvent);
        puzPieceSound.start();
    }

    public virtual void puzPieceJingleSnd()
    {
        puzPieceJingleSound = FMODUnity.RuntimeManager.CreateInstance(puzPieceJingleEvent);
        puzPieceJingleSound.start();
    }




}