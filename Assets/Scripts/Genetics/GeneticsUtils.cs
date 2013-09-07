using UnityEngine;
using System.Collections;

/*
 *		Author: 	Craig Lomax
 *		Date: 		26.07.2013
 *		URL:		clomax.me.uk
 *		email:		craig@clomax.me.uk
 *
 */


public class GeneticsUtils {
	
	static System.Random rnd = new System.Random();

	public static float[] mutate (float[] c, int length, double rate, float factor) {
		for (int i=0; i<length; i++) {
			double rand = rnd.NextDouble();
			if (rand < rate)
				c[i] += (float) rnd.NextDouble() * ( Mathf.Abs(factor-(-factor)) ) + (-factor);
		}
		return c;
	}
	
	public static float[] crossover (float[] c1, float[] c2, int length, double rate) {
		float[] newChromosome = c1;
		for (int i=0; i<length; i++) {
			double rand = rnd.NextDouble();
			if (rand < rate)
				newChromosome[i] = c2[i];
		}
		
		return newChromosome;
	}
	
}