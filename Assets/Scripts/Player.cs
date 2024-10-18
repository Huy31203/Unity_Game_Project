using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	private Rigidbody rb;
	private Animator animator;

	[SerializeField] float speed = 20f;
	private float horizontalInput;

	// Jump
	[SerializeField] float jumpForce = 17f;
	private bool isGrounded;

	// Status
	bool isAlive = true;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		animator = gameObject.GetComponentInChildren<Animator>();
	}

	void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Jump();
		}

		if (transform.position.y < -10)
		{
			Die();
		}
	}

	private void FixedUpdate()
	{
		if (!isAlive) return;

		Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
		Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
		rb.MovePosition(rb.position + forwardMove + horizontalMove);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isGrounded = true;
		}
	}

	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isGrounded = true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isGrounded = false;
		}
	}

	void Jump()
	{
		if (isGrounded)
		{
			animator.SetTrigger("Jump");
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}

	public void Die()
	{
		isAlive = false;
		GameOver();
	}

	void GameOver()
	{
		SceneManager.LoadScene("GameOver");
	}
}
