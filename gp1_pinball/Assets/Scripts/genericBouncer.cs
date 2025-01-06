// Copyright #Team1 2025. All rights Reserved.

using UnityEngine;

public class genericBouncer : MonoBehaviour
{
	 
	 
	[Header(" ")]
	// animations related
	[Header("Animations")]
	[SerializeField] bool isHit = false;
	[SerializeField] Animator animator;
	[SerializeField] float animationTime = 3f;
	[SerializeField] float animationTimer = 0f;
	 
	 
	[Header(" ")]
	// sounds related
	[Header("Sounds")]
	[SerializeField] AudioSource audioSource;
	[SerializeField] AudioClip audioClipBouncer1;
	 
	 
	 
	 
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	 {
		  
		// getting components of object
		animator = GetComponent<Animator>();
		audioSource = GetComponent<AudioSource>();

		// setting up animation
		animationTimer = animationTime;

	 }

	 // Update is called once per frame
	 void Update()
	 {
		AnimationTimerToIdle();
	 }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			isHit = true;
			PlayAnimation();
			PlaySound(audioClipBouncer1);
		}
	}

	private void PlayAnimation()
	{

		Debug.Log("animation");
		//animator.SetBool("repel", true);

	}

	private void AnimationTimerToIdle()
	{

		if (isHit)
		{
			if (animationTimer > 0f)
			{
				animationTimer -= Time.deltaTime;
			}
			else
			{
				//animator.SetBool("repel", false);
				animationTimer = animationTime;
				isHit = false;
				Debug.Log("animation ends");
			}
		}

	}

	private void PlaySound(AudioClip clip)
	{
		
		Debug.Log("sound");
		//audioSource.clip = clip;
		//audioSource.Play();

	}

}
