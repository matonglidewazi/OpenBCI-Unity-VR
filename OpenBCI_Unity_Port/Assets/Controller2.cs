﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour {

	void Start () {

		ParticleBehaviour2.G2_emissionRate = 100f;
		ParticleBehaviour2.G2_rotate = 0f;
		ParticleBehaviour2.G2_color_1 = 0.2f;
		ParticleBehaviour2.G2_speed = 10f;

	}
	

	void Update () {

		ParticleBehaviour2.G2_speed = ParticleBehaviour2.G2_speed + Random.Range (-0.1f, 0.1f);
		ParticleBehaviour2.G2_emissionRate = ParticleBehaviour2.G2_emissionRate+ 0.1f;
		ParticleBehaviour2.G2_translate = ParticleBehaviour2.G2_translate + Random.Range (-0.001f, 0.001f);
		ParticleBehaviour2.G2_rotate = ParticleBehaviour2.G2_rotate + Random.Range (-0.01f, 0.01f);
		
	}
}
